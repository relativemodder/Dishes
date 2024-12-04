using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DishesApp.Services
{
    public class Database
    {
        private static Database? instance;

        private MySqlConnection? connection;

        public static Database GetDatabase()
        {
            if (instance == null)
            {
                instance = new Database();
            }

            return instance;
        }

        public string GetConnectionString()
        {
            string host = Environment.GetEnvironmentVariable("DISHES_DB_HOST") ?? "localhost";
            string name = Environment.GetEnvironmentVariable("DISHES_DB_NAME") ?? "dishes";
            string user = Environment.GetEnvironmentVariable("DISHES_DB_USER") ?? "root";
            string password = Environment.GetEnvironmentVariable("DISHES_DB_PASSWORD") ?? "";

            return $"server={host};uid={user};pwd={password};database={name}";
        }

        private MySqlConnection Connect()
        {
            connection = new MySqlConnection(GetConnectionString());
            connection.Open();

            return connection;
        }

        public MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = Connect();
            }

            return connection;
        }


    }
}
