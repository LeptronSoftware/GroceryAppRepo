using GroceryApp.ViewModels;

namespace GroceryApp.Views;

public partial class ProductsListView 
{
	public ProductsListView(ProductsListViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}