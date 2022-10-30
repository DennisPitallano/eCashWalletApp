using eCashWalletApp.ViewModels;

namespace eCashWalletApp;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}