namespace todo_app.entity;

public class Account
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}