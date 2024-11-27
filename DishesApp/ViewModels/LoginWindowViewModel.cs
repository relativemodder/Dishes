namespace DishesApp.ViewModels
{
    public partial class LoginWindowViewModel : ViewModelBase
    {
        public string EmailString { get; } = "E-mail";
        public string PasswordString { get; } = "Пароль";
        public string LoginString { get; } = "Войти";
        public string RegisterString { get; } = "Регистрация";
    }
}
