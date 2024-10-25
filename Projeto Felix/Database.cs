
using MySql.Data.MySqlClient;
using System.Data;

public class Database
{
    private MySqlConnection connection;

    public Database()
    {
        string connectionString = "server=localhost;database=CrudExample;user=root;password=uninove;";
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}

