using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using DishesApp.ViewModels;

namespace DishesApp.Views
{
    public partial class RegistrationWindow : Window
    {
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
