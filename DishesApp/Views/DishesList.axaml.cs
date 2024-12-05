using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DishesApp.Models;
using DishesApp.ViewModels;
using System.Collections.Generic;

namespace DishesApp.Views
{
    public partial class DishesList : UserControl
    {
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
            }
        }
    }
}