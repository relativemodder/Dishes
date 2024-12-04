using DishesApp.Services;

namespace DishesApp.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";
        public Session? Session { get; set; }
    }
}
