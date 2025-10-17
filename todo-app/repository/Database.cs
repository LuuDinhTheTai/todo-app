// New file: Database helper for SQL Server
using Microsoft.Data.SqlClient;

namespace todo_app.repository;

public static class Database
{
    // Default connection string points to LocalDB. Change this value to point to your SQL Server instance.
    // Example for a SQL Server instance: "Server=.;Database=TodoAppDb;User Id=sa;Password=YourPassword;"
    public static string ConnectionString { get; set; } = "Server=(localdb)\\MSSQLLocalDB;Database=TodoAppDb;Trusted_Connection=True;";

    public static SqlConnection GetConnection()
    {
        var conn = new SqlConnection(ConnectionString);
        conn.Open();
        return conn;
    }
}

