using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository;

public class TodoRepository : Repository
{
    public void Create(Todo todo)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "INSERT INTO Todos (Content, IsDone, Priority) VALUES (@Content, @IsDone, @Priority); SELECT CAST(SCOPE_IDENTITY() AS int);";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Content", todo.Content);
                command.Parameters.AddWithValue("@IsDone", todo.IsDone);
                command.Parameters.AddWithValue("@Priority", todo.Priority);
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
            string sql = "SELECT Id, Content, IsDone, Priority FROM Todos";
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
                            Priority = reader.GetInt32(reader.GetOrdinal("Priority"))
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
                SELECT T.Id, T.Content, T.IsDone , T.Note, T.Priority
                FROM Todos T
                JOIN TodoTags TT ON T.Id = TT.TodoId
                WHERE TT.TagId = @TagId
                ORDER BY T.Priority DESC, T.Id ASC";

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
                            Note = reader.IsDBNull(reader.GetOrdinal("Note"))? "" : reader.GetString(reader.GetOrdinal("Note")),
                            Priority = reader.GetInt32(reader.GetOrdinal("Priority"))
                        };
                        todos.Add(todo);
                    }
                }
            }
        }

        return todos;
    }

    public void AddTag(int todoId, int tagId)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            connection.Open();
            string sql = "INSERT INTO TodoTags (TodoId, TagId) VALUES (@TodoId, @TagId)";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@TodoId", todoId);
                command.Parameters.AddWithValue("@TagId", tagId);
                command.ExecuteNonQuery();
            }
        }
    }

    public Todo FindById(int todoId)
    {
        using (var conn = Database.GetConnection())
        {
            conn.Open();
            string sql = "SELECT Id, Content, Note, IsDone, Priority FROM Todos WHERE Id = @Id";

            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", todoId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Todo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Content = reader.GetString(reader.GetOrdinal("Content")),
                            Note = reader.IsDBNull(reader.GetOrdinal("Note")) ? "" : reader.GetString(reader.GetOrdinal("Note")),
                            IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                            Priority = reader.GetInt32(reader.GetOrdinal("Priority"))
                        };
                    }
                }
            }
        }
        return null;
    }

    public void Update(Todo todo)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "UPDATE Todos SET Content = @Content, IsDone = @IsDone , Priority = @Priority, Note =@Note  WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Content", todo.Content);
                command.Parameters.AddWithValue("@IsDone", todo.IsDone);
                command.Parameters.AddWithValue("@Id", todo.Id);
                command.Parameters.AddWithValue("@Priority", todo.Priority);
                command.Parameters.AddWithValue("@Note", todo.Note);
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