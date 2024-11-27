using CommunityToolkit.Mvvm.ComponentModel;

namespace DishesApp.ViewModels
{
    public class ViewModelBase : ObservableObject
    {
        public string CompanyName { get; } = "ООО \"Посуда\"";
    }
}
