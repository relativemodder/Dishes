using DishesApp.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DishesApp.Services
{
    public class Users
    {
        private static Users? instance;

        public static Users GetInstance()
        {
            if (instance == null)
            {
                instance = new Users();
            }

            return instance;
        }

        public User.Role? GetRole(int id)
        {
            var connection = Database.GetDatabase().GetConnection();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = @"SELECT * FROM Role WHERE RoleID = @id";
            myCommand.Parameters.AddWithValue("@id", id);

            MySqlDataReader rdr = myCommand.ExecuteReader();


            while (rdr.Read())
            {
                return new User.Role()
                {
                    Id = id,
                    Name = rdr.GetString("RoleName")
                };
            }
            rdr.Close();
            Database.GetDatabase().CloseConnection();

            return null;
        }

        public User? GetUser(int id, string? login = null)
        {
            Database.GetDatabase().CloseConnection();
            var connection = Database.GetDatabase().GetConnection();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = @"SELECT * FROM User WHERE UserID = @id OR UserLogin LIKE @login";
            myCommand.Parameters.AddWithValue("@id", id);
            myCommand.Parameters.AddWithValue("@login", login ?? "holyshittheresnologin092185498u2198r1uhf98132fh");

            MySqlDataReader rdr;

            try
            {
                rdr = myCommand.ExecuteReader();
            }
            catch (MySqlException)
            {
                connection = Database.GetDatabase().GetConnection();
                rdr = myCommand.ExecuteReader();
            }


            User? user;

            while (rdr.Read())
            {
                int roleId = rdr.GetInt32("UserRole");

                user = new User()
                {
                    Id = rdr.GetInt32("UserID"),
                    Surname = rdr.GetString("UserSurname"),
                    Name = rdr.GetString("UserName"),
                    Patronymic = rdr.GetString("UserPatronymic"),
                    Login = rdr.GetString("UserLogin"),
                    Password = rdr.GetString("UserPassword"),
                    UserRole = new User.Role()
                };
                rdr.Close();

                user.UserRole = GetRole(roleId);

                return user;
            }

            return null;
        }

        public User Register(string login, string password, string surname, string name, string patronymic)
        {
            var connection = Database.GetDatabase().GetConnection();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = @"INSERT INTO User (UserSurname, UserName, UserPatronymic, UserLogin, UserPassword) 
                VALUES (@surname, @name, @patronymic, @login, @password)";
            myCommand.Parameters.AddWithValue("@surname", surname);
            myCommand.Parameters.AddWithValue("@password", password);
            myCommand.Parameters.AddWithValue("@login", login);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@patronymic", patronymic);

            myCommand.ExecuteNonQuery();
            var id = (int)myCommand.LastInsertedId;
            Database.GetDatabase().CloseConnection();

            return GetUser(id);
        }

        public User? Login(string login, string password)
        {
            Database.GetDatabase().CloseConnection();
            var userByLogin = GetUser(0, login);

            if (userByLogin == null)
            {
                return null;
            }

            if (userByLogin.Password != password)
            {
                return null;
            }

            return userByLogin;
        }
    }
}
