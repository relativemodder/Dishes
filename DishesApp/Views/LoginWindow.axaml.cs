using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using DishesApp.Services;
using DishesApp.ViewModels;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;

namespace DishesApp.Views
{
    public partial class LoginWindow : Window
    {
        public delegate void LoggedInDelegate();
        public event LoggedInDelegate LoggedIn;

        public LoginWindow()
        {
            InitializeComponent();
            KeyDown += LoginWindow_KeyDown;
            LoginButton.Click += LoginButton_Click;
            RegistrationButton.Click += RegistrationButton_Click;
        }

        private void LoginWindow_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) {
                Close();
            }
        }

        private void RegistrationButton_Click(object? sender, RoutedEventArgs e)
        {
            Hide();
            var registrationWindow = new RegistrationWindow();
            registrationWindow.DataContext = new RegistrationWindowViewModel();
            registrationWindow.ShowDialog(App.CurrentWindow);
            registrationWindow.OnRegistration += () =>
            {
                LoggedIn?.Invoke();
            };
            Close();
        }

        private void LoginButton_Click(object? sender, RoutedEventArgs e)
        {
            var loginResult = Users.GetInstance().Login(EmailTextBox.Text, PasswordTextBox.Text);

            if (loginResult == null)
            {
                var box = MessageBoxManager
                    .GetMessageBoxStandard("Ошибка", $"Неверный логин или пароль!",
                       ButtonEnum.Ok, MsBox.Avalonia.Enums.Icon.Forbidden);

                box.ShowAsync();
                return;
            }

            Session.GetInstance().SetUser(loginResult);

            LoggedIn?.Invoke();
            Close();
        }
    }
}
