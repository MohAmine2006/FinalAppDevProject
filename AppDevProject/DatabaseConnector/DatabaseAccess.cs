using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AppDevProject.DatabaseConnector
{
    public static class DatabaseAccess
    {
        // Database connection string
        private const string ConnectionString = "server=127.0.0.1;user=root;password=;database=expense;";

        // Returns Connection safely
        public static MySqlConnection GetConnection()
        {
            try
            {
                var conn = new MySqlConnection(ConnectionString);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed:\n" + ex.Message);
                return null;
            }
        }
    }
}

