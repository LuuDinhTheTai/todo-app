namespace todo_app.entity;

public class Todo
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public bool IsDone { get; set; } = false;
    public int Priority { get; set; } = 1;
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}