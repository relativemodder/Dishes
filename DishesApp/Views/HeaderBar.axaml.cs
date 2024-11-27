using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DishesApp.ViewModels;

namespace DishesApp.Views
{
    public partial class HeaderBar : UserControl
    {
        public HeaderBar()
        {
            InitializeComponent();
            LoginButton.Click += LoginButton_Click;
            RegistrationButton.Click += RegistrationButton_Click;
        }
        
        private void LoginButton_Click(object? sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            var parentWindow = MainWindow.GetInstance();
            loginWindow.DataContext = new LoginWindowViewModel();
            loginWindow.ShowDialog(parentWindow);
        }

        private void RegistrationButton_Click(object? sender, RoutedEventArgs e)
        {
            var registrationWindow = new RegistrationWindow();
            registrationWindow.DataContext = new RegistrationWindowViewModel();
            registrationWindow.ShowDialog(MainWindow.GetInstance());
        }

    }
}