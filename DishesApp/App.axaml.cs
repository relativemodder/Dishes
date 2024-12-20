using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia;
using DishesApp.ViewModels;
using DishesApp.Views;
using System.Linq;
using DishesApp.Services;
using MsBox.Avalonia.Enums;
using System;

namespace DishesApp
{
    public partial class App : Application
    {
        public static Window CurrentWindow { get; set; }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
                // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
                DisableAvaloniaDataAnnotationValidation();


                try
                {
                    Database.GetDatabase().GetConnection();
                }
                catch (Exception ex)
                {
                    var box = MessageBoxManager
                    .GetMessageBoxStandard("Ошибка!", $"Не удалось подключиться к базе данных. \n\nПодробнее: {ex.Message}",
                       ButtonEnum.Ok, Icon.Database);

                    box.ShowAsync();

                    return;
                }

                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }

        public static void NavigateTo(Window previousWindow, Window window, ViewModelBase viewModel)
        {
            previousWindow.Hide();
            window.DataContext = viewModel;
            window.Show();
            previousWindow.Close();
        }

        private void DisableAvaloniaDataAnnotationValidation()
        {
            // Get an array of plugins to remove
            var dataValidationPluginsToRemove =
                BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

            // remove each entry found
            foreach (var plugin in dataValidationPluginsToRemove)
            {
                BindingPlugins.DataValidators.Remove(plugin);
            }
        }
    }
}