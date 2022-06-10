using Katsumi.ViewModels;

namespace Katsumi.Pages;

public partial class ProductListPage : ContentPage
{
	public ProductListPage(ProductListViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}