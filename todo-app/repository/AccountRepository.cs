using Microsoft.Data.SqlClient;
using todo_app.entity;
using todo_app.exception;

namespace todo_app.repository;

public class AccountRepository
{
    public void Create(Account account)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "INSERT INTO Accounts (Username, Password) VALUES (@Username, @Password)";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Username", account.Username);
                command.Parameters.AddWithValue("@Password", account.Password);
                command.ExecuteNonQuery();
            }
        }    
    }
    
    public Account? FindByUsername(string username)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "SELECT Id, Username, Password FROM Accounts WHERE Username = @Username";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var account = new Account
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            Password = reader.GetString(reader.GetOrdinal("Password"))
                        };
                        return account;
                    }
                }
            }
        }

        return null;
    }

    public void UpdatePassword(int accountId, string newPassword)
    {
        using (SqlConnection connection = Database.GetConnection())
        {
            string sql = "UPDATE Accounts SET [Password] = @Password WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@Id", accountId);
                int affected = command.ExecuteNonQuery();
                if (affected == 0)
                {
                    throw new AppException("Không thể cập nhật mật khẩu.");
                }
            }
        }
    }
}
