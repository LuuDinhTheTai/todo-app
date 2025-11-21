using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository
{
    public class TodoRepository
    {
        public int Create(Todo todo)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "INSERT INTO Todos (Content, Note, DueDate, IsDone, IsImportant, ParentId) " +
                             "OUTPUT INSERTED.Id " +
                             "VALUES (@Content, @Note, @DueDate, @IsDone, @IsImportant, @ParentId);";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Content", todo.Content);
                    command.Parameters.AddWithValue("@Note", (object)todo.Note ?? DBNull.Value);
                    command.Parameters.AddWithValue("@DueDate", (object)todo.DueDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@IsDone", todo.IsDone);
                    command.Parameters.AddWithValue("@IsImportant", todo.IsImportant);
                    command.Parameters.AddWithValue("@ParentId", (object)todo.ParentId ?? DBNull.Value);

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public Todo? FindById(int id)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "SELECT Id, Content, IsDone, Note, DueDate, IsImportant, ParentId FROM Todos WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Todo
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Content = reader.GetString(reader.GetOrdinal("Content")),
                                IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                                Note = reader.IsDBNull(reader.GetOrdinal("Note")) ? null : reader.GetString(reader.GetOrdinal("Note")),
                                DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DueDate")),
                                IsImportant = reader.GetBoolean(reader.GetOrdinal("IsImportant")),
                                ParentId = reader.IsDBNull(reader.GetOrdinal("ParentId")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ParentId"))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public ICollection<Todo> FindByTagId(int tagId)
        {
            var todos = new List<Todo>();
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "SELECT t.Id, t.Content, t.IsDone, t.Note, t.DueDate, t.IsImportant, t.ParentId " +
                             "FROM Todos t INNER JOIN TagTodo tt ON t.Id = tt.TodoId " +
                             "WHERE tt.TagId = @TagId AND t.ParentId IS NULL";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@TagId", tagId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            todos.Add(new Todo
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Content = reader.GetString(reader.GetOrdinal("Content")),
                                IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                                Note = reader.IsDBNull(reader.GetOrdinal("Note")) ? null : reader.GetString(reader.GetOrdinal("Note")),
                                DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DueDate")),
                                IsImportant = reader.GetBoolean(reader.GetOrdinal("IsImportant")),
                                ParentId = reader.IsDBNull(reader.GetOrdinal("ParentId")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ParentId"))
                            });
                        }
                    }
                }
            }
            return todos;
        }

        public List<Todo> FindByParentId(int parentId)
        {
            var todos = new List<Todo>();
            using (SqlConnection connection = Database.GetConnection())
            {
                string sql = "SELECT Id, Content, IsDone, Note, DueDate, IsImportant, ParentId FROM Todos WHERE ParentId = @ParentId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ParentId", parentId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            todos.Add(new Todo
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Content = reader.GetString(reader.GetOrdinal("Content")),
                                IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                                Note = reader.IsDBNull(reader.GetOrdinal("Note")) ? null : reader.GetString(reader.GetOrdinal("Note")),
                                DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DueDate")),
                                IsImportant = reader.GetBoolean(reader.GetOrdinal("IsImportant")),
                                ParentId = reader.IsDBNull(reader.GetOrdinal("ParentId")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ParentId"))
                            });
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
                string sql = "UPDATE Todos SET Content = @Content, IsDone = @IsDone, Note = @Note, " +
                             "DueDate = @DueDate, IsImportant = @IsImportant, ParentId = @ParentId WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", todo.Id);
                    command.Parameters.AddWithValue("@Content", todo.Content);
                    command.Parameters.AddWithValue("@IsDone", todo.IsDone);
                    command.Parameters.AddWithValue("@Note", (object)todo.Note ?? DBNull.Value);
                    command.Parameters.AddWithValue("@DueDate", (object)todo.DueDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@IsImportant", todo.IsImportant);
                    command.Parameters.AddWithValue("@ParentId", (object)todo.ParentId ?? DBNull.Value);
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
}
