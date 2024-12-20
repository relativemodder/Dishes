﻿using DishesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesApp.Services
{
    public class Session
    {
        public delegate void GlobalStateChanged(Session session);
        public event GlobalStateChanged OnGlobalStateChanged;

        private static Session? instance;

        private User? user;
        private Dictionary<Product, int> cart = new Dictionary<Product, int>();

        public static Session GetInstance()
        {
            if (instance == null)
            {
                instance = new Session();
            }

            return instance;
        }

        public User? GetUser()
        {
            return user;
        }

        public void SetUser(User user)
        {
            this.user = user;
            OnGlobalStateChanged?.Invoke(this);
        }

        public Dictionary<Product, int> GetCart()
        {
            return cart;
        }

        public void AddToCart(Product product, int count)
        {
            cart[product] = cart.GetValueOrDefault(product, 0) + count;
        }
    }
}
