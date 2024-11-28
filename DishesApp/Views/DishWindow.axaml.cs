using Avalonia.Controls;

namespace DishesApp.Views
{
    public partial class DishWindow : Window
    {

        public DishWindow()
        {
            InitializeComponent();
            WindowHeaderBar.DataContext = new ViewModels.HeaderBarViewModel();
        }
    }
}