using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace InriWebTest.Models
{
    public class UserStoreContext
    {
        public string ConnectionString { get; set; }
        public UserStoreContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}