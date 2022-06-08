using Katsumi.ViewModels;

namespace Katsumi.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();

		BindingContext = mainViewModel;
    }
}

