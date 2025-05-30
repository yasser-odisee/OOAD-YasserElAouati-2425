using System.Data.SqlClient;

namespace BenchmarkLib
{
    public static class Database
    {
        private static readonly string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BenchmarkDB;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
