using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroceryApp.Models;
using GroceryApp.Services.API;
using GroceryApp.Services.Location;
using GroceryApp.Services.Navigation;
using GroceryApp.Services.ShareInfo;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GroceryApp.ViewModels
{
    public partial class ProductShowViewModel : ViewModelBase
    {
        IProductsService _productsService;
        ILocationService _locationService;
        IShareInfoService _shareInfoService;

        [ObservableProperty]
        public partial ProductDetail ProductDetailItem { get; set; }
        public ProductShowViewModel(IProductsService productsService, ILocationService locationService,IShareInfoService shareInfoService, INavigationService navigationService)
            : base(navigationService)
        {
            _productsService = productsService;
            _locationService = locationService;
            _shareInfoService = shareInfoService;
        }
        public override void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            base.ApplyQueryAttributes(query);

            ProductDetailItem = query.ValueAs<ProductDetail>("ProductDetailItem");
        }

        [RelayCommand]
        private async Task ShareAsync()
        {
            var city = await _locationService.GetCity();
            var title = ProductDetailItem.title ?? "";
            var info = $"{title} - {ProductDetailItem.price} from {city} added to list";
            _ = _shareInfoService.ShareInfo(title, info);
        }
    }
}
