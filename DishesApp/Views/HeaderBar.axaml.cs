using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DishesApp.Services;
using DishesApp.ViewModels;
using Mysqlx.Connection;

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

            DataContextChanged += HeaderBar_DataContextChanged;

            if (Session.GetInstance().GetUser() != null)
            {
                if (DataContext == null)
                {
                    DataContext = new HeaderBarViewModel()
                    {
                        Session = Session.GetInstance()
                    };
                }

                var data = DataContext as HeaderBarViewModel;
                data.Session = Session.GetInstance();

                HeaderBar_DataContextChanged(null, null);
            }
        }

        private void HeaderBar_DataContextChanged(object? sender, EventArgs e)
        {
            var data = DataContext as HeaderBarViewModel;
            if (Session.GetInstance().GetUser() != null)
            {
                data.Session = Session.GetInstance();
                LoginButton.Content = data.Session.GetUser().Name;
                RegistrationButton.IsVisible = false;
            }
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

        public void LoginButton_Click(object? sender, RoutedEventArgs e)
        {
            var data = DataContext as HeaderBarViewModel;

            if (data.Session != null)
            {
                return;
            }

            var loginWindow = new LoginWindow();
            loginWindow.DataContext = new LoginWindowViewModel();
            loginWindow.ShowDialog(App.CurrentWindow);

            loginWindow.LoggedIn += () =>
            {
                if (Session.GetInstance().GetUser() != null)
                {
                    data.Session = Session.GetInstance();
                    HeaderBar_DataContextChanged(null, null);
                }
                else
                {
                    MainWindow.GetInstance().Close();
                }
            };

        }

        private void RegistrationButton_Click(object? sender, RoutedEventArgs e)
        {
            var data = DataContext as HeaderBarViewModel;

            var registrationWindow = new RegistrationWindow();
            registrationWindow.DataContext = new RegistrationWindowViewModel();
            registrationWindow.ShowDialog(App.CurrentWindow);

            registrationWindow.OnRegistration += () =>
            {
                if (Session.GetInstance().GetUser() != null)
                {
                    data.Session = Session.GetInstance();
                    HeaderBar_DataContextChanged(null, null);
                }
            };
        }

    }
}