using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroceryApp.Models;
using GroceryApp.Services.API;
using GroceryApp.Services.Navigation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace GroceryApp.ViewModels
{
    public partial class ProductsListViewModel : ViewModelBase
    {
        IProductsService _productsService;   
     
        [ObservableProperty]
        public partial Product SelectedProduct { get; set; }


        [ObservableProperty]
        public partial ObservableCollection<Product>? Products { get; set; }
        public ProductsListViewModel(IProductsService productsService, INavigationService navigationService)
            :base(navigationService)
        {
            _productsService = productsService;
            IsInitialized = false;
        }
        public override async Task InitializeAsync()
        {
            await IsBusyFor(
                async () =>
                {
                    try
                    {
                        IsInitialized = false;
                        var products = await _productsService.GetProducts();
                        Products = new ObservableCollection<Product>(products);
                        IsInitialized = true;
                    }
                    catch (Exception ex)
                    {
                        //TODO: log something
                    }
                });
        }
        [RelayCommand]
        private async Task ShowAsync(Product item)
        {
            SelectedProduct = null;

            if (item is null)
            {
                return;
            }
            if (IsInitialized)
            {
                var productDetail = await _productsService.GetProductDetail(item.id);

                await NavigationService.NavigateToAsync(
                    "ProductShowView",
                    new Dictionary<string, object> { ["ProductDetailItem"] = productDetail });
            }
        }
    }
}
