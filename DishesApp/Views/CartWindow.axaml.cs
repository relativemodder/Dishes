using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DishesApp.ViewModels;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

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
        }


        private async void OrderButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CartWindowViewModel context = (CartWindowViewModel)DataContext;

            var box = MessageBoxManager.GetMessageBoxStandard(
                "Заказать?", $"Вы точно хотите заказать {context.ProductCount} товаров?", 
                ButtonEnum.YesNo
            );
            var result = await box.ShowAsync();

            if (result == ButtonResult.Yes)
            {
                var box1 = MessageBoxManager.GetMessageBoxStandard(
                    "Успех!", $"Успешно заказано {context.ProductCount} товаров!",
                    ButtonEnum.Ok
                );
                await box1.ShowAsync();
            }
        }
    }
}