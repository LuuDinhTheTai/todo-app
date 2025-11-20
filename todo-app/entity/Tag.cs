using System.Collections.Generic;

namespace todo_app.entity;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int AccountId { get; set; }
}