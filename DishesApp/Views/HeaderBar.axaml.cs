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
            LogoPanel.PointerPressed += LogoPanel_PointerPressed;
            ShoppingCartButton.Click += ShoppingCartButton_Click;
            LoginButton.Click += LoginButton_Click;
            RegistrationButton.Click += RegistrationButton_Click;
        }

        private void ShoppingCartButton_Click(object? sender, RoutedEventArgs e)
        {
            var prevWindow = App.CurrentWindow;
            var cartWindow = new CartWindow();
            App.NavigateTo(prevWindow, cartWindow, new CartWindowViewModel() { Products = new System.Collections.Generic.List<Models.Product>()});
        }

        private void LogoPanel_PointerPressed(object? sender, PointerPressedEventArgs e)
        {
            var prevWindow = App.CurrentWindow;
            var mainWindow = new MainWindow();
            App.NavigateTo(prevWindow, mainWindow, new MainWindowViewModel());
        }

        private void LoginButton_Click(object? sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.DataContext = new LoginWindowViewModel();
            loginWindow.ShowDialog(App.CurrentWindow);
        }

        private void RegistrationButton_Click(object? sender, RoutedEventArgs e)
        {
            var registrationWindow = new RegistrationWindow();
            registrationWindow.DataContext = new RegistrationWindowViewModel();
            registrationWindow.ShowDialog(App.CurrentWindow);
        }

    }
}