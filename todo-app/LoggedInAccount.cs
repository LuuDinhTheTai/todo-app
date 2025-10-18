using todo_app.entity;
using todo_app.exception;

namespace todo_app;

public class LoggedInAccount
{
    private Account? _account = null;

    public void SetAccount(Account account)
    {
        if (_account != null)
        {
            throw new AppException("Đã có tài khoản đăng nhập");
        }
        _account = account;
    }

    public int GetId()
    {
        if (_account == null)
        {
            throw new AppException("Chưa có tài khoản đăng nhập");
        }
        return _account.Id;
    }

    public string GetUsername()
    {
        if (_account == null)
        {
            throw new AppException("Chưa có tài khoản đăng nhập");
        }
        return _account.Username;
    }
    
    public bool IsLoggedIn()
    {
        if (_account == null)
        {
            return false;
        }
        return true;
    }
}