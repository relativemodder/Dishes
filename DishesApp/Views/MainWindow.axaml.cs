using Avalonia.Controls;

namespace DishesApp.Views
{
    public partial class MainWindow : Window
    {
        private static MainWindow instance;

        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            WindowHeaderBar.DataContext = new ViewModels.HeaderBarViewModel();
        }

        public static MainWindow GetInstance() {
            return instance ??= new MainWindow();
        }
    }
}