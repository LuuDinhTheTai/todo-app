using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository;

public class TodoRepository : Repository
{
    public void Create(Todo todo)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "INSERT INTO Todos (Content, TagId) VALUES (@Content, @TagId); SELECT CAST(SCOPE_IDENTITY() AS int);";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Content", todo.Content);
                command.Parameters.AddWithValue("@TagId", todo.TagId);

                var result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int newId))
                {
                    todo.Id = newId;
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
                        var todo = new Todo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Content = reader.GetString(reader.GetOrdinal("Content")),
                            IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                            DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DueDate"))

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
            string sql = "SELECT Id, Content, IsDone, Note, DueDate, TagId FROM Todos WHERE TagId = @TagId";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@TagId", tagId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var todo = new Todo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Content = reader.GetString(reader.GetOrdinal("Content")),
                            IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                            Note = reader.IsDBNull(reader.GetOrdinal("Note")) ? string.Empty : reader.GetString(reader.GetOrdinal("Note")),
                            DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DueDate")),
                            TagId = reader.GetInt32(reader.GetOrdinal("TagId"))
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
            string sql = "UPDATE Todos SET Content = @Content, IsDone = @IsDone, Note = @Note, DueDate = @DueDate WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Content", todo.Content);
                command.Parameters.AddWithValue("@IsDone", todo.IsDone);
                command.Parameters.AddWithValue("@Id", todo.Id);
                command.Parameters.AddWithValue("@Note", todo.Note);
                command.Parameters.AddWithValue("@DueDate", (object?)todo.DueDate ?? DBNull.Value);
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
