using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppDevProject.DatabaseConnector
{
    public static class DatabaseAccess
    {
        private const string ConnectionString = "server=127.0.0.1;user=root;password=;database=expense;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}

