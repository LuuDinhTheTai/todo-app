using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository;

public class TodoRepository : Repository
{
    public void Create(Todo todo)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "INSERT INTO Todos (Content, IsDone, DueDate) VALUES (@Content, @IsDone, @DueDate); SELECT CAST(SCOPE_IDENTITY() AS int);";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Content", todo.Content);
                command.Parameters.AddWithValue("@IsDone", todo.IsDone);
                command.Parameters.AddWithValue("@DueDate", (object?)todo.DueDate ?? DBNull.Value);

                var result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int newId))
                {
                    todo.Id = newId;
                }
            }
        }

        if (todo.Tags.Count == 0)
            return;

        foreach (var tag in todo.Tags)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "INSERT INTO TodoTags (TodoId, TagId) VALUES (@TodoId, @TagId)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TodoId", todo.Id);
                    command.Parameters.AddWithValue("@TagId", tag.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }


    public ICollection<Todo> FindAll()
    {
        var todos = new List<Todo>();

        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "SELECT Id, Content, IsDone, DueDate FROM Todos";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ordId = reader.GetOrdinal("Id");
                        int ordContent = reader.GetOrdinal("Content");
                        int ordIsDone = reader.GetOrdinal("IsDone");
                        int ordDueDate = reader.GetOrdinal("DueDate");

                        var todo = new Todo
                        {
                            Id = reader.GetInt32(ordId),
                            Content = reader.GetString(ordContent),
                            IsDone = reader.GetBoolean(ordIsDone),
                            DueDate = reader.IsDBNull(ordDueDate) ? (DateTime?)null : reader.GetDateTime(ordDueDate)
                        };
                        todos.Add(todo);
                    }
                }
            }
        }

        return todos;
    }

    public ICollection<Todo> FindByTagId(int tagId)
    {
        var todos = new List<Todo>();

        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = @"
                SELECT T.Id, T.Content, T.IsDone, T.DueDate
                FROM Todos T
                JOIN TodoTags TT ON T.Id = TT.TodoId
                WHERE TT.TagId = @TagId";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@TagId", tagId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ordId = reader.GetOrdinal("Id");
                        int ordContent = reader.GetOrdinal("Content");
                        int ordIsDone = reader.GetOrdinal("IsDone");
                        int ordDueDate = reader.GetOrdinal("DueDate");

                        var todo = new Todo
                        {
                            Id = reader.GetInt32(ordId),
                            Content = reader.GetString(ordContent),
                            IsDone = reader.GetBoolean(ordIsDone),
                            DueDate = reader.IsDBNull(ordDueDate) ? (DateTime?)null : reader.GetDateTime(ordDueDate)
                        };
                        todos.Add(todo);
                    }
                }
            }
        }

        return todos;
    }

    public void Update(Todo todo)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "UPDATE Todos SET Content = @Content, IsDone = @IsDone, DueDate = @DueDate WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Content", todo.Content);
                command.Parameters.AddWithValue("@IsDone", todo.IsDone);
                command.Parameters.AddWithValue("@DueDate", (object?)todo.DueDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@Id", todo.Id);
                command.ExecuteNonQuery();
            }
        }
    }

    public void Delete(int id)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "DELETE FROM Todos WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
