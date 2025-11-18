using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service
{
    public class SubTodoService
    {
        private TagRepository _tagRepository;
        private TodoRepository _todoRepository;
        private LoggedInAccount _loggedInAccount;
        private SubTodoRepository _subTodoRepository;

        public SubTodoService(Controller controller)
        {
            _tagRepository = controller.TagRepository;
            _todoRepository = controller.TodoRepository;
            _loggedInAccount = controller.LoggedInAccount;
            _subTodoRepository = controller.SubTodoRepository;
        }

        public void Create(string? content, Todo? todo)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new AppException("Nội dung công việc không hợp lệ.");
            }
            
            if (todo == null)
            {
                throw new AppException("Danh sách không hợp lệ.");
            }

            SubTodo subtodo = new SubTodo();
            subtodo.Content = content;

            subtodo.TodoId = todo.Id;
            _subTodoRepository.Create(subtodo);
        }

        public List<SubTodo> FindByTodoId(int todoId)
        {
            return _subTodoRepository.FindByTodoId(todoId).ToList();
        }

        public void CheckSubTodo(int id, bool isDone)
        {
            var subtodo = _subTodoRepository.FindById(id);
            if (subtodo == null)
            {
                throw new AppException("Tác vụ không tồn tại.");
            }

            subtodo.IsDone = isDone;
            _subTodoRepository.Update(subtodo);
        }

        public void Delete(int id)
        {
            _subTodoRepository.Delete(id);
        }

    }
}
