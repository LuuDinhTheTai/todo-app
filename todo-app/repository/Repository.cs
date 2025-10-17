using Microsoft.Data.SqlClient;

namespace todo_app.repository;

public abstract class Repository
{
    protected SqlConnection GetConnection() => Database.GetConnection();
}