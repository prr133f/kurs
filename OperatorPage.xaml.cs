using System.Collections.ObjectModel;
using System.Diagnostics;
using Buses.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Buses;

public sealed partial class OperatorPage : Page
{
    Operator _operator = new();
    readonly ObservableCollection<string> Routes = [];
    readonly ObservableCollection<string> Buses = [];

    public OperatorPage()
    {
        this.InitializeComponent();

        Routes.Add("Маршрут No1");
        Routes.Add("Маршрут No2");
        
        Buses.Add("Автобус No1");
        Buses.Add("Автобус No2");
    }

    public void SetRoute(object sender, SelectionChangedEventArgs e)
        => _operator = _operator.SetRoute((string)e.AddedItems[0]);

    public void SetBus(object sender, SelectionChangedEventArgs e)
        => _operator = _operator.SetBus((string)e.AddedItems[0]);

    public void Submit(object sender, RoutedEventArgs a)
    {
        try {
            _operator = _operator.Submit();
        } catch (Exceptions.NothingToSubmitException e) {
            Debug.WriteLine(e.Message);
            ContentDialog errorDialog = new()
            {
                Title = "Ошибка",
                Content = e.Message,
                CloseButtonText = "ОК"
            };

            _ = errorDialog.ShowAsync();
        }
    }
}