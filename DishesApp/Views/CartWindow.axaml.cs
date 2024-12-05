using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DishesApp.Services;
using DishesApp.ViewModels;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using System.Linq;

namespace DishesApp.Views
{
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();
            App.CurrentWindow = this;
            WindowHeaderBar.DataContext = new ViewModels.HeaderBarViewModel();
            OrderButton.Click += OrderButton_Click;

            Opened += CartWindow_Opened;
        }

        private void CartWindow_Opened(object? sender, System.EventArgs e)
        {
            CartWindowViewModel context = (CartWindowViewModel)DataContext;

            var products = Session.GetInstance().GetCart();
            CartProductsList.IsCart = true;
            CartProductsList.LoadData(products.Keys.ToList());

            double sum = 0;

            foreach (var product in products)
            {
                context.ProductCount += product.Value;
                sum += product.Key.Cost * product.Value;
            }

            CartPriceTextBlock.Text = sum + " руб.";
            ProductCountTextBlock.Text = context.ProductCount.ToString();
        }

        private async void OrderButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CartWindowViewModel context = (CartWindowViewModel)DataContext;

            var box = MessageBoxManager.GetMessageBoxStandard(
                "Подтверждение", $"Вы точно хотите заказать {context.ProductCount} товаров?", 
                ButtonEnum.YesNo,
                MsBox.Avalonia.Enums.Icon.Question
            );
            var result = await box.ShowAsync();

            if (result == ButtonResult.Yes)
            {
                var box1 = MessageBoxManager.GetMessageBoxStandard(
                    "Успех!", $"Заказано {context.ProductCount} товаров!",
                    ButtonEnum.Ok,
                    MsBox.Avalonia.Enums.Icon.Success
                );
                await box1.ShowAsync();
            }
        }
    }
}