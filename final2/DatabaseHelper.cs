using System;
using System.Data;
using System.Data.SqlClient;

namespace test1
{
    public static class DatabaseHelper
    {
        // Universal connection string for local Microsoft SQL Server Express
        public static string ConnectionString = @"Server=DESKTOP-TJJ99FG\SQLEXPRESS;Database=RAC_DB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static bool TestConnection(out string errorMessage)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    errorMessage = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
