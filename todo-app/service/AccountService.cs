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
        ValidateUsername(username);
        ValidatePassword(password);
        
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

    public void ChangePassword(string? oldPassword, string? newPassword, string? confirmNewPassword)
    {
        if (!_loggedInAccount.IsLoggedIn())
        {
            throw new AppException("Chưa đăng nhập.");
        }

        if (string.IsNullOrEmpty(oldPassword))
        {
            throw new AppException("Mật khẩu cũ không hợp lệ.");
        }

        ValidatePassword(newPassword);

        if (string.IsNullOrEmpty(confirmNewPassword))
        {
            throw new AppException("Nhập lại mật khẩu mới không hợp lệ.");
        }

        if (newPassword != confirmNewPassword)
        {
            throw new AppException("Mật khẩu mới không khớp.");
        }

        var account = _accountRepository.FindByUsername(_loggedInAccount.GetUsername());
        if (account == null)
        {
            throw new AppException("Tài khoản không tồn tại.");
        }

        if (account.Password != oldPassword)
        {
            throw new AppException("Mật khẩu cũ không đúng.");
        }

        _accountRepository.UpdatePassword(account.Id, newPassword!);
    }

    private void ValidateUsername(string? username)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new AppException("Tài khoản không hợp lệ.");
        }
        if (username.Length < 5)
        {
            throw new AppException("Tài khoản phải có ít nhất 5 ký tự.");
        }
        if (username.Length > 20)
        {
            throw new AppException("Tài khoản không được quá 20 ký tự.");
        }
    }

    private void ValidatePassword(string? password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new AppException("Mật khẩu không hợp lệ.");
        }
        if (password.Length < 5)
        {
            throw new AppException("Mật khẩu phải có ít nhất 5 ký tự");
        }
        if (password.Length > 20)
        {
            throw new AppException("Mật khẩu không được quá 20 ký tự");
        }
    }

    public void Login(string? username, string? password)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new AppException("Tài khoản không hợp lệ");
        }

        if (string.IsNullOrEmpty(password))
        {
            throw new AppException("Mật khẩu không hợp lệ");
        }
        
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
