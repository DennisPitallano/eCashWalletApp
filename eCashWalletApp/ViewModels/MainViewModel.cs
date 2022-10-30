using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace eCashWalletApp.ViewModels;

public partial class MainViewModel : ObservableObject
{

    public MainViewModel()
    {
       
    }
    [RelayCommand]
    private async Task LogIn()
    {
        await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
    }
}