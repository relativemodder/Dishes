using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using DishesApp.ViewModels;

namespace DishesApp.Views
{
    public partial class LoginWindow : Window
    {
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
            Close();
        }

        private void LoginButton_Click(object? sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
