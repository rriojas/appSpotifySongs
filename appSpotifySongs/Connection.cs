using Microsoft.Data.SqlClient;
using System.Data;

namespace appSpotifySongs
{
  internal class Connection
  {
    private static SqlConnection connection;
    // Connection string
    public static void Connect()
    {
      string connectionString = @"Server=localhost\SQLEXPRESS;Database=Tec;User Id=tec;Password=tec;TrustServerCertificate=true;";
       connection = new SqlConnection(connectionString);
      connection.Open();
    }
    public static void Disconnect()
    {
      connection.Close();
    }
    // Execute a query
    public static void ExecuteQuery(string query)
    {
      Connect();
      SqlCommand command = new SqlCommand(query, connection);
      command.ExecuteNonQuery();
      Disconnect();
    }
    // Execute a query and return the result as datatable
    public static DataTable GetDataTable(string query)
    {
      Connect();
      SqlCommand command = new SqlCommand(query, connection);
      DataTable dataTable = new DataTable();
      dataTable.Load(command.ExecuteReader());
      Disconnect();
      return dataTable;
    }

  }
}
