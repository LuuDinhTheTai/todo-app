using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service
{
    public class TagService
    {
        private readonly TagRepository _tagRepository;
        private readonly LoggedInAccount _loggedInAccount;
        private readonly TagTodoRepository _tagTodoRepository;

        public TagService(Controller controller)
        {
            _tagRepository = controller.TagRepository;
            _loggedInAccount = controller.LoggedInAccount;
            _tagTodoRepository = controller.TagTodoRepository;
        }

        public void Create(string? tagName)
        {
            if (string.IsNullOrEmpty(tagName))
            {
                throw new AppException("Tên danh sách không hợp lệ.");
            }

            bool isExisted = _tagRepository.FindByName(tagName) != null;
            if (isExisted)
            {
                throw new AppException("Danh sách đã tồn tại.");
            }

            var tag = new Tag
            {
                AccountId = _loggedInAccount.GetId(),
                Name = tagName
            };
            _tagRepository.Create(tag);
        }

        public List<Tag> FindAll()
        {
            return _tagRepository.FindByAccountId(_loggedInAccount.GetId()).ToList();
        }

        public Tag FindByTodoId(int todoId)
        {
            var tagTodos = _tagTodoRepository.FindByTodoId(todoId);
            Tag tag = _tagRepository.FindById(tagTodos[0].TagId);
            if (tag == null)
            {
                throw new AppException("Danh sách không tồn tại.");
            }

            return tag;
        }

        public void Delete(int id)
        {
            _tagRepository.Delete(id);
        }
    }
}
