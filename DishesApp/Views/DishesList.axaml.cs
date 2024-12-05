using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DishesApp.Models;
using DishesApp.Services;
using DishesApp.ViewModels;
using System.Collections.Generic;

namespace DishesApp.Views
{
    public partial class DishesList : UserControl
    {
        public bool IsCart = false;

        private List<Product> products;

        public DishesList()
        {
            InitializeComponent();
        }

        public void LoadData(List<Product> products)
        {
            this.products = products;
            UpdateList();
        }

        public void UpdateList()
        {
            ItemsStack.Children.Clear();

            foreach (Product product in products)
            {
                var item = new DishItem();
                item.DataContext = new DishItemViewModel { Product = product };
                ItemsStack.Children.Add(item);

                if (IsCart)
                {
                    item.FirstText.Text = "Количество:";
                    item.SecondText.Text = Session.GetInstance().GetCart().GetValueOrDefault(product, 0) + " шт.";
                }
            }
        }
    }
}