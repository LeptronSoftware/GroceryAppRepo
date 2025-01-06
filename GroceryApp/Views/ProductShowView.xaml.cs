using GroceryApp.ViewModels;

namespace GroceryApp.Views;

public partial class ProductShowView : ContentPageBase
{
	public ProductShowView(ProductShowViewModel viewModel)
	{
		BindingContext = viewModel;

        InitializeComponent();
	}
}