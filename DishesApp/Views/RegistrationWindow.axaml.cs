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
    public partial class RegistrationWindow : Window
    {
        public delegate void OnRegistrationDelegate();
        public event OnRegistrationDelegate OnRegistration;

        public RegistrationWindow()
        {
            InitializeComponent();
            KeyDown += RegistrationWindow_KeyDown;
            RegistrationButton.Click += RegistrationButton_Click;
            LoginButton.Click += LoginButton_Click;
        }

        private void RegistrationWindow_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) {
                Close();
            }
        }

        private void RegistrationButton_Click(object? sender, RoutedEventArgs e)
        {
            var userResult = Users.GetInstance().Register(
                EmailTextBox.Text,
                PasswordTextBox.Text,
                SurnameTextBox.Text,
                NameTextBox.Text,
                PatronymicTextBox.Text
            );

            Session.GetInstance().SetUser(userResult);

            OnRegistration?.Invoke();

            Close();
        }

        private void LoginButton_Click(object? sender, RoutedEventArgs e)
        {
            Hide();
            var loginWindow = new LoginWindow();
            loginWindow.DataContext = new LoginWindowViewModel();
            loginWindow.ShowDialog(App.CurrentWindow);
            Close();
        }

    }
}
