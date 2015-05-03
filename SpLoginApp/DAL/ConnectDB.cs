using System.Configuration;
using System.Data.SqlClient;

namespace SpLoginApp
{
    public class ConnectDb
    {
        public static SqlConnection GetSqlConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LoginDB"].ConnectionString;
            var conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
