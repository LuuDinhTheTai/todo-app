using todo_app.controller;
using todo_app.repository;

namespace todo_app.service
{
    public class ChartService
    {
        private Controller _controller;
        private TodoRepository _todoRepository;
        
        public ChartService(Controller controller)
        {
            _controller = controller;
            _todoRepository = controller.TodoRepository;
        }
        
        public (int doneCount, int undoneCount) GetTodoStatistics(int tagId)
        {
            var tagTodos = _todoRepository.FindByTagId(tagId);
            var doneCount = tagTodos.Count(todo => todo.IsDone);
            var undoneCount = tagTodos.Count(todo => !todo.IsDone);
            return (doneCount, undoneCount);
        }

    }
}
