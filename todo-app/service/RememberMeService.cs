//using todo_app.Properties;

namespace todo_app.service;

public class RememberMeService
{
    public void Save(string username, string password)
    {
        // var s = Settings.Default;
        // s.RememberMe_Username = username ?? string.Empty;
        // s.RememberMe_Password = password ?? string.Empty;
        // s.RememberMe_Enabled = true;
        // s.Save();
    }

    // public bool Load(out string username, out string password)
    // {
    //     var s = Settings.Default;
    //     username = s.RememberMe_Username ?? string.Empty;
    //     password = s.RememberMe_Password ?? string.Empty;
    //
    //     if (!s.RememberMe_Enabled ||
    //         string.IsNullOrWhiteSpace(username) ||
    //         string.IsNullOrWhiteSpace(password))
    //     {
    //         username = password = string.Empty;
    //         return false;
    //     }
    //     return true;
    // }

    public void Clear()
    {
        // var s = Settings.Default;
        // s.RememberMe_Username = string.Empty;
        // s.RememberMe_Password = string.Empty;
        // s.RememberMe_Enabled = false;
        // s.Save();
    }
}
