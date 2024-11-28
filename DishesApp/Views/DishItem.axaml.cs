using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using DishesApp.ViewModels;
using System;

namespace DishesApp.Views
{
    public partial class DishItem : UserControl
    {
        public DishItem()
        {
            InitializeComponent();
            PointerPressed += OnPointerPressed;
        }

        private void OnPointerPressed(object? sender, PointerPressedEventArgs e)
        {
            var prevWindow = App.CurrentWindow;
            var dishWindow = new DishWindow();
            App.NavigateTo(prevWindow, dishWindow, new DishWindowViewModel()
            {
                Product = null
            });
        }
    }
}
