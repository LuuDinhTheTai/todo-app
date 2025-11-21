using System.Collections.Generic;

namespace todo_app.entity;

public class Todo
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public string? Note { get; set; }
    public DateTime? DueDate { get; set; }
    public bool IsDone { get; set; }
    public bool IsImportant { get; set; }
    public int? ParentId { get; set; }
}