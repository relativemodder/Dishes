using DishesApp.Services;
using System.ComponentModel;

namespace DishesApp.ViewModels
{
    public partial class HeaderBarViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string LogoText { get; } = "Посуда";
        public string ShoppingCartString { get; } = "Корзина";
        public string LoginString { get; } = "Войти";
        public string RegistrationString { get; } = "Регистрация";
        public Session? Session { get; set; }
    }
}
