using DishesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesApp.Services
{
    public class Session
    {
        private static Session? instance;

        private User? user;

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
        }
    }
}
