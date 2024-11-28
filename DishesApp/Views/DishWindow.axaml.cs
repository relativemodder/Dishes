using Avalonia.Controls;

namespace DishesApp.Views
{
    public partial class DishWindow : Window
    {

        public DishWindow()
        {
            InitializeComponent();
            App.CurrentWindow = this;
            WindowHeaderBar.DataContext = new ViewModels.HeaderBarViewModel();
        }
    }
}