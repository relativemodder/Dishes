using DishesApp.Models;

namespace DishesApp.ViewModels
{
    public partial class DishWindowViewModel : ViewModelBase
    {
        public required Product Product { get; set; }
        public string ProductNameString { get; } = "Название: ";
        public string ProductManufacturerString { get; } = "Производитель: ";
        public string ProductArticleString { get; } = "Артикул: ";
        public string ProductCategoryString { get; } = "Категория: ";
        public string ProductDiscountString { get; } = "Скидка!!! ";
        public string ProductDiscountAmountCString { get; } = "%";
        public string CurrencyString { get; } = " руб.";
    }
}
