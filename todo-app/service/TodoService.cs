using todo_app.controller;
using todo_app.entity;
using todo_app.repository;

namespace todo_app.service;

public class TodoService
{
    private TodoRepository _todoRepository;
    
    public TodoService(Controller controller)
    {
        _todoRepository = controller.TodoRepository;
    }
    
    public void Create(string content)
    {
        Todo todo = new Todo();
        todo.Content = content;
        _todoRepository.Create(todo);
    }
    
    public ICollection<Todo> FindAll()
    {
        return _todoRepository.FindAll();
    }

    public void Delete(int id)
    {
        _todoRepository.Delete(id);
    }
}   