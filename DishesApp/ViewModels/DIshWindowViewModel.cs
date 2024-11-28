using DishesApp.Models;

namespace DishesApp.ViewModels
{
    public partial class DishWindowViewModel : ViewModelBase
    {
        public required Product Product { get; set; }
        public string ProductNameString { get; } = "��������: ";
        public string ProductManufacturerString { get; } = "�������������: ";
        public string ProductArticleString { get; } = "�������: ";
        public string ProductCategoryString { get; } = "���������: ";
        public string ProductDiscountString { get; } = "������!!! ";
        public string ProductDiscountAmountCString { get; } = "%";
        public string CurrencyString { get; } = " ���.";
    }
}
