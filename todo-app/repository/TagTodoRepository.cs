using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository
{
    public class TagTodoRepository
    {
        public void Create(TagTodo tagTodo)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "INSERT INTO TagTodo (TagId, TodoId) VALUES (@TagId, @TodoId)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TagId", tagTodo.TagId);
                    command.Parameters.AddWithValue("@TodoId", tagTodo.TodoId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<TagTodo> FindByTodoId(int todoId)
        {
            List<TagTodo> tagTodos = new List<TagTodo>();
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "SELECT TagId, TodoId FROM TagTodo WHERE TodoId = @TodoId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TodoId", todoId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tagTodos.Add(new TagTodo
                            {
                                TagId = reader.GetInt32(reader.GetOrdinal("TagId")),
                                TodoId = reader.GetInt32(reader.GetOrdinal("TodoId"))
                            });
                        }
                    }
                }
            }
            return tagTodos;
        }

        public void Delete(TagTodo tagTodo)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
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
