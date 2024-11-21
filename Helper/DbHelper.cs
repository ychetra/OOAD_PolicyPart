using System.Data.SqlClient;

namespace OOAD_Form.Helper
{
    public static class DbHelper
    {
        private static string connectionString = "Data Source= chetra-acer\\SQLEXPRESS ;Initial Catalog= OOAD ;TrustServerCertificate=True;Integrated Security=True;Pooling=False;Encrypt=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
} 