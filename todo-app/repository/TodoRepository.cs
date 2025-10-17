using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository;

public class TodoRepository : Repository
{

    public void Create(Todo todo)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "INSERT INTO Todos (Content, IsDone) VALUES (@Content, @IsDone)";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Content", todo.Content);
                command.Parameters.AddWithValue("@IsDone", todo.IsDone);
                command.ExecuteNonQuery();
            }
        }
    }

    public ICollection<Todo> FindAll()
    {
        var todos = new List<Todo>();

        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "SELECT Id, Content, IsDone FROM Todos";
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
                            IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone"))
                        };
                        todos.Add(todo);
                    }
                }
            }
        }

        return todos;
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