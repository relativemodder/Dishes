using DishesApp.Models;
using System.Collections.Generic;

namespace DishesApp.ViewModels
{
    public partial class CartWindowViewModel : ViewModelBase
    {
        public string Title { get; } = "Корзина";
        public string OrderButtonString { get; } = "Заказать";
        public string ProductCountString { get; } = "Товаров: ";
        public string ClearButtonString { get; } = "Очистить";
        public required List<Product> Products { get; set; }
        public int ProductCount 
        { 
            get 
            {
                return Products.Count;    
            } 
        }
    }
}
