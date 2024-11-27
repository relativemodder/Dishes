namespace DishesApp.ViewModels
{
    public partial class HeaderBarViewModel : ViewModelBase
    {
        public string LogoText { get; } = "Посуда";
        public string ShoppingCartString { get; } = "Корзина";
        public string LoginString { get; } = "Войти";
        public string RegistrationString { get; } = "Регистрация";
    }
}
