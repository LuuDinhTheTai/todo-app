using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service;

public class TodoService
{
    private TodoRepository _todoRepository;
    
    public TodoService(Controller controller)
    {
        _todoRepository = controller.TodoRepository;
    }
    
    public void Create(string content, Tag tag, int priority = 1)
    {
        Todo todo = new Todo();
        todo.Content = content;
        todo.Tags.Add(tag);
        todo.Priority = priority;
        _todoRepository.Create(todo);
        _todoRepository.AddTag(todo.Id, tag.Id);
    }
    
    public List<Todo> FindByTagId(int tagId)
    {
        return _todoRepository.FindByTagId(tagId).ToList();
    }
    
    public void Update(Todo newTodo)
    {
        _todoRepository.Update(newTodo);
    }

    public void UpdateTodoPriority(int todoId, int newPriority)
    {
        var todo = _todoRepository.FindById(todoId); 
        if (todo == null) throw new AppException("Todo không tồn tại");

        todo.Priority = newPriority;
        _todoRepository.Update(todo);
    }

    public Todo? FindById(int id)
    {
        return _todoRepository.FindById(id);
    }

    public void UpdateTodoFull(Todo todo)
    {
        // dùng khi update content, status, note, priority...
        _todoRepository.Update(todo);
    }

    public ICollection<Todo> GetTodosForTag(Tag tag)
    {
        if (tag == null) throw new AppException("Chưa chọn danh sách");
        return _todoRepository.FindByTagId(tag.Id);
    }

    public void Delete(int id)
    {
        _todoRepository.Delete(id);
    }
}   