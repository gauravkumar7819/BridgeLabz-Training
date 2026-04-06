using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace AddressBookSystem.Database
{
   public class DBConnection
    {
        private static string connectionString =
          
"Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}