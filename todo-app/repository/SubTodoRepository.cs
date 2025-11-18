using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository
{
    public class SubTodoRepository : Repository
    {
        public void Create(SubTodo subtodo)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "INSERT INTO SubTodos (Content, TodoId) VALUES (@Content, @TodoId);";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Content", subtodo.Content);
                    command.Parameters.AddWithValue("@TodoId", subtodo.TodoId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public SubTodo? FindById(int id)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "SELECT Id, Content, IsDone, TodoId FROM SubTodos WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var subtodo = new SubTodo
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Content = reader.GetString(reader.GetOrdinal("Content")),
                                IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                                TodoId = reader.GetInt32(reader.GetOrdinal("TodoId"))
                            };
                            return subtodo;
                        }
                    }
                }
            }
            return null;
        }

        public void Update(SubTodo subtodo)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "UPDATE SubTodos SET Content = @Content, IsDone = @IsDone WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Content", subtodo.Content);
                    command.Parameters.AddWithValue("@IsDone", subtodo.IsDone);
                    command.Parameters.AddWithValue("@Id", subtodo.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "DELETE FROM SubTodos WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public ICollection<SubTodo> FindByTodoId(int todoId)
        {
            var subtodos = new List<SubTodo>();

            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "SELECT Id, Content, IsDone, TodoId FROM SubTodos WHERE TodoId = @TodoId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TodoId", todoId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var subtodo = new SubTodo
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Content = reader.GetString(reader.GetOrdinal("Content")),
                                IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                                TodoId = reader.GetInt32(reader.GetOrdinal("TodoId"))
                            };
                            subtodos.Add(subtodo);
                        }
                    }
                }
            }

            return subtodos;
        }


    }
}
