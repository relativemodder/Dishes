using Avalonia.Controls;
using DishesApp.Services;
using DishesApp.ViewModels;
using System;

namespace DishesApp.Views
{
    public partial class MainWindow : Window
    {
        private static MainWindow instance;

        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            App.CurrentWindow = instance;

            WindowHeaderBar.DataContext = new ViewModels.HeaderBarViewModel();

            DataContextChanged += MainWindow_DataContextChanged;
            WindowHeaderBar.DataContextChanged += WindowHeaderBar_DataContextChanged;

            Opened += (s, idk) =>
            {
                if (Session.GetInstance().GetUser() == null)
                {
                    WindowHeaderBar.LoginButton_Click(null, null);
                }
            };

            var products = Products.GetInstance().GetProducts();
            this.DishesList.LoadData(products);
        }

        private void WindowHeaderBar_DataContextChanged(object? sender, EventArgs e)
        {
            var data = WindowHeaderBar.DataContext as MainWindowViewModel;

            if (data.Session != null)
            {
                (DataContext as HeaderBarViewModel).Session = data.Session;
            }
        }

        private void MainWindow_DataContextChanged(object? sender, System.EventArgs e)
        {
            var data = DataContext as MainWindowViewModel;

            if (data.Session != null)
            {
                (WindowHeaderBar.DataContext as HeaderBarViewModel).Session = data.Session;
            }
        }

        public static MainWindow GetInstance() {
            return instance ??= new MainWindow();
        }
    }
}