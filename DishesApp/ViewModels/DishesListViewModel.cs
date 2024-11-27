using System.Collections.Generic;
using DishesApp.Models;

namespace DishesApp.ViewModels
{
    public partial class DishesListViewModel : ViewModelBase
    {
        public required List<Product> Products { get; set; }
    }
}
