using System;
using System.Collections.Generic;
using System.Linq;
using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service
{
    public class TodoService
    {
        private readonly TagRepository _tagRepository;
        private readonly TodoRepository _todoRepository;
        private readonly TagTodoRepository _tagTodoRepository;
        private readonly LoggedInAccount _loggedInAccount;

        public TodoService(Controller controller)
        {
            _tagRepository = controller.TagRepository;
            _todoRepository = controller.TodoRepository;
            _tagTodoRepository = controller.TagTodoRepository;
            _loggedInAccount = controller.LoggedInAccount;
        }

        public void Create(string? content, DateTime? dueDate, Tag? tag, bool isImportant = false, int? parentId = null)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new AppException("Nội dung công việc không hợp lệ.");
            }
            if (dueDate == null)
            {
                throw new AppException("Ngày hết hạn không hợp lệ.");
            }
            if (tag == null)
            {
                throw new AppException("Danh sách không hợp lệ.");
            }

            var todo = new Todo
            {
                Content = content,
                DueDate = dueDate.Value,
                IsImportant = isImportant,
                ParentId = parentId
            };

            int todoId = _todoRepository.Create(todo);

            var tagTodo = new TagTodo
            {
                TodoId = todoId,
                TagId = tag.Id
            };
            _tagTodoRepository.Create(tagTodo);
        }

        public List<Todo> FindByTagId(int tagId)
        {
            return _todoRepository.FindByTagId(tagId).ToList();
        }

        public void UpdateDueDate(int id, DateTime? dueDate)
        {
            var todo = _todoRepository.FindById(id);
            if (todo == null)
            {
                throw new AppException("Tác vụ không tồn tại.");
            }
            if (dueDate == null)
            {
                throw new AppException("Ngày hết hạn không hợp lệ.");
            }
            todo.DueDate = dueDate.Value;
            _todoRepository.Update(todo);
        }

        public void UpdateNote(int id, string? note)
        {
            var todo = _todoRepository.FindById(id);
            if (todo == null)
            {
                throw new AppException("Tác vụ không tồn tại.");
            }
            todo.Note = note;
            _todoRepository.Update(todo);
        }

        public void Delete(int id)
        {
            _todoRepository.Delete(id);
        }

        public void CheckTodo(int id, bool isDone)
        {
            var todo = _todoRepository.FindById(id);
            if (todo == null)
            {
                throw new AppException("Tác vụ không tồn tại.");
            }

            todo.IsDone = isDone;
            _todoRepository.Update(todo);
        }

        public List<Todo> SearchTodos(string? keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                throw new AppException("Từ khóa tìm kiếm không hợp lệ.");
            }

            var todos = new List<Todo>();
            var tags = (List<Tag>)_tagRepository.FindByAccountId(_loggedInAccount.GetId());

            foreach (var tag in tags)
            {
                var tagTodos = _todoRepository.FindByTagId(tag.Id);
                foreach (var todo in tagTodos)
                {
                    if (todo.Content.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        (todo.Note != null && todo.Note.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                    {
                        todos.Add(todo);
                    }
                }
            }

            return todos;
        }

        public List<Todo> SortByDueDate(int tagId, bool ascending = true)
        {
            var todos = _todoRepository.FindByTagId(tagId).ToList();
            var sortedTodos = ascending
                ? todos.OrderBy(t => t.DueDate).ToList()
                : todos.OrderByDescending(t => t.DueDate).ToList();
            return sortedTodos;
        }

        public List<Todo> SortByContent(int tagId, bool ascending = true)
        {
            var todos = _todoRepository.FindByTagId(tagId).ToList();
            var sortedTodos = ascending
                ? todos.OrderBy(t => t.Content, StringComparer.OrdinalIgnoreCase).ToList()
                : todos.OrderByDescending(t => t.Content, StringComparer.OrdinalIgnoreCase).ToList();
            return sortedTodos;
        }
    }
}
