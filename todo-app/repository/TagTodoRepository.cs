using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository
{
    public class TagTodoRepository : Repository
    {
        public void Create(TagTodo tagTodo)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO TagTodo (TagId, TodoId) VALUES (@TagId, @TodoId)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TagId", tagTodo.TagId);
                    command.Parameters.AddWithValue("@TodoId", tagTodo.TodoId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(TagTodo tagTodo)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string sql = "DELETE FROM TagTodo WHERE TagId = @TagId AND TodoId = @TodoId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TagId", tagTodo.TagId);
                    command.Parameters.AddWithValue("@TodoId", tagTodo.TodoId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
