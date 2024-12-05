using Avalonia.Controls;
using DishesApp.Services;
using DishesApp.ViewModels;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;

namespace DishesApp.Views
{
    public partial class DishWindow : Window
    {
        private int wishCount = 0;

        public DishWindow()
        {
            InitializeComponent();
            App.CurrentWindow = this;
            WindowHeaderBar.DataContext = new ViewModels.HeaderBarViewModel();

            DecreaseCountButton.Click += DecreaseCountButton_Click;
            IncreaseCountButton.Click += IncreaseCountButton_Click;
            AddButton.Click += AddButton_Click;
        }

        private async void AddButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var product = (DataContext as DishWindowViewModel).Product;
            Session.GetInstance().AddToCart(product, int.Parse(CountBox.Text));

            var box1 = MessageBoxManager.GetMessageBoxStandard(
                    "Успех!", $"Добавлено {CountBox.Text} {product.Name} в корзину.",
                    ButtonEnum.Ok,
                    MsBox.Avalonia.Enums.Icon.Success
                );
            await box1.ShowAsync();
        }

        private void IncreaseCountButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            wishCount++;
            UpdateCounter();
        }

        private void DecreaseCountButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            wishCount--;
            UpdateCounter();
        }

        private void UpdateCounter()
        {
            CountBox.Text = wishCount.ToString();
        }
    }
}