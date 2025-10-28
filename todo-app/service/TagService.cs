using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service;

public class TagService
{
    private TagRepository _tagRepository;
    
    private LoggedInAccount _loggedInAccount;
    
    public TagService(Controller controller)
    {
        _tagRepository = controller.TagRepository;
        _loggedInAccount = controller.LoggedInAccount;
    }
    
    public void Create(string? tagName)
    {
        if (string.IsNullOrEmpty(tagName))
        {
            throw new AppException("Tên danh sách không hợp lệ.");
        }

        bool isExisted = _tagRepository.FindByName(tagName) != null;
        if (isExisted)
        {
            throw new AppException("Danh sách đã tồn tại.");
        }

        Tag tag = new Tag();
        tag.AccountId = _loggedInAccount.GetId();
        tag.Name = tagName;
        _tagRepository.Create(tag);
    }

    public List<Tag> FindAll()
    {
        var tags = _tagRepository.FindByAccountId(_loggedInAccount.GetId());
        return tags.ToList();
    }

    public Tag FindByName(string? name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new AppException("Tên danh sách không hợp lệ.");
        }

        Tag? tag = _tagRepository.FindByName(name);
        if (tag == null)
        {
            throw new AppException("Tag không tồn tại.");
        }
        
        return tag;
    }

    public void Delete(int id)
    {
        _tagRepository.Delete(id);
    }
}