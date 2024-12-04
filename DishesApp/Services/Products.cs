﻿using DishesApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmds.DBus.Protocol;

namespace DishesApp.Services
{
    public class Products
    {
        private static Products? instance;

        public static Products GetInstance()
        {
            if (instance == null)
            {
                instance = new Products();
            }

            return instance;
        }

        public Product GetProduct(string article)
        {
            Database db = Database.GetDatabase();
            db.CloseConnection();
            var connection = db.GetConnection();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = @"SELECT * FROM Product WHERE ProductArticleNumber = @article";
            myCommand.Parameters.AddWithValue("@article", article);

            MySqlDataReader rdr;

            rdr = myCommand.ExecuteReader();

            while (rdr.Read())
            {
                var product = new Product()
                {
                    ArticleNumber = rdr.GetString("ProductArticleNumber"),
                    Name = rdr.GetString("ProductName"),
                    Category = rdr.GetString("ProductCategory"),
                    Cost = (double)rdr.GetDecimal("ProductCost"),
                    Description = rdr.GetString("ProductDescription"),
                    DiscountAmount = rdr.GetInt32("ProductDiscountAmount"),
                    Manufacturer = rdr.GetString("ProductManufacturer"),
                    Photo = null,
                    QuantityInStock = rdr.GetInt32("ProductQuantityInStock"),
                    Status = rdr.GetString("ProductStatus")
                };

                connection.Close();

                return product;
            }

            return null;
        }
    }
}