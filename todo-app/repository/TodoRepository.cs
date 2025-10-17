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

    public void Delete(int id)
    {
        
    }
}