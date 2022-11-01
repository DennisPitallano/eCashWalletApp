using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace eCashWalletApp.ViewModels;

public partial class DashboardViewModel: ObservableObject
{
    [ObservableProperty] private ObservableCollection<string> _items;

    public DashboardViewModel()
    {
        _items = new ObservableCollection<string>()
        {
            "ORAGON SAVINGS",
            "ORAGON PAYROLL"
        };
    }
}