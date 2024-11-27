using DishesApp.Models;

namespace DishesApp.ViewModels
{
    public partial class DishItemViewModel : ViewModelBase
    {
        public required Product Product { get; set; }
        public int WishAmount { get; set; } = 0;
    }
}
