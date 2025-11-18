using System.IO;
namespace todo_app.service;

public class RememberMeService
{
    private readonly string _filePath = "rememberme.txt";

    public void Save(string username, string password)
    {
        File.WriteAllLines(_filePath, new[] { username, password });
    }

    public bool Load(out string username, out string password)
    {
        username = password = string.Empty;

        if (!File.Exists(_filePath)) return false;

        var lines = File.ReadAllLines(_filePath);
        if (lines.Length >= 2)
        {
            username = lines[0].Trim();
            password = lines[1].Trim();
            return true;
        }

        return false;
    }

    public void Clear()
    {
        if (File.Exists(_filePath))
            File.Delete(_filePath);
    }
}
