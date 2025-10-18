using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service;

public class AccountService
{
    private AccountRepository _accountRepository;
    private LoggedInAccount _loggedInAccount;
    
    public AccountService(Controller controller)
    {
        _accountRepository = controller.AccountRepository;
        _loggedInAccount = controller.LoggedInAccount;
    }

    public void Register(string? username, string? password, string? confirmPassword)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new AppException("Tài khoản không hợp lệ.");
        }
        
        if (string.IsNullOrEmpty(password))
        {
            throw new AppException("Mật khẩu không hợp lệ.");
        }
        
        if (string.IsNullOrEmpty(confirmPassword))
        {
            throw new AppException("Nhập lại mật khẩu không hợp lệ.");
        }
        
        if (password != confirmPassword)
        {
            throw new AppException("Mật khẩu không khớp.");
        }

        Account? account = _accountRepository.FindByUsername(username);
        bool isExisted = account != null;
        if (isExisted)
        {
            throw new AppException("Tài khoản đã tồn tại.");
        }

        account = new Account
        {
            Username = username,
            Password = password
        };

        _accountRepository.Create(account);
    }

    public void Login(string username, string password)
    {
        Account? account = _accountRepository.FindByUsername(username);
        
        bool isExisted = account != null;
        if (!isExisted)
        {
            throw new AppException("Tài khoản không tồn tại");
        }

        bool isValidPassword = password == account.Password;
        if (!isValidPassword)
        {
            throw new AppException("Mật khẩu không đúng");
        }
        
        _loggedInAccount.SetAccount(account);
    }
}