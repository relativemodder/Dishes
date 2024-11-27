namespace DishesApp.ViewModels
{
    public partial class RegistrationWindowViewModel : ViewModelBase
    {
        public string EmailString { get; } = "E-mail";
        public string SurnameString { get; } = "Фамилия";
        public string NameString { get; } = "Имя";
        public string PatronymicString { get; } = "Отчество";
        public string PasswordString { get; } = "Пароль";
        public string RegistrationString { get; } = "Регистрация";
        public string ContinueString { get; } = "Продолжить";
        public string LoginProposalString { get; } = "Уже есть аккаунт?";
    }
}
