using Microsoft.Data.SqlClient;
using todo_app.entity;

namespace todo_app.repository;

public class TagRepository : Repository
{
    public void Create(Tag tag)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "INSERT INTO Tags (AccountId, Name) VALUES (@AccountId, @Name)";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@AccountId", tag.AccountId);
                command.Parameters.AddWithValue("@Name", tag.Name);
                command.ExecuteNonQuery();
            }
        }
    }

    public ICollection<Tag> FindByAccountId(int id)
    {
        List<Tag> tags = new List<Tag>();
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "SELECT Id, AccountId, Name FROM Tags WHERE AccountId = @AccountId";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@AccountId", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tag tag = new Tag
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            AccountId = reader.GetInt32(reader.GetOrdinal("AccountId")),
                            Name = reader.GetString(reader.GetOrdinal("Name"))
                        };
                        tags.Add(tag);
                    }
                }
            }
        }
        return tags;
    }
}