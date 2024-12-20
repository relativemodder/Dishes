﻿using System;
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

        public static Database GetDatabase()
        {
            if (instance == null)
            {
                instance = new Database(); // Реализуем паттерн Singleton
            }

            return instance;
        }

        public string GetConnectionString()
        { 
            // Безопасно берём из ОС переменные среды

            string host = Environment.GetEnvironmentVariable("DISHES_DB_HOST") ?? "localhost";
            string name = Environment.GetEnvironmentVariable("DISHES_DB_NAME") ?? "dishes";
            string user = Environment.GetEnvironmentVariable("DISHES_DB_USER") ?? "root";
            string password = Environment.GetEnvironmentVariable("DISHES_DB_PASSWORD") ?? "";

            return $"server={host};uid={user};pwd={password};database={name}";
        }

        private MySqlConnection Connect()
        {
            var connection = new MySqlConnection(GetConnectionString());
            connection.Open();

            return connection;
        }

        public MySqlConnection GetConnection()
        {

            return Connect();
        }

        public void CloseConnection()
        {
            // if (connection == null) return;
            // 
            // connection.Close();
            // connection = null;
        }


    }
}
