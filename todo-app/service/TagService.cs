using todo_app.controller;
using todo_app.entity;
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
    
    public void Create(string tagName)
    {
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
}