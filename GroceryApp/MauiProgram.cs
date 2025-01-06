using CommunityToolkit.Maui;

using GroceryApp.Services;
using GroceryApp.Services.API;
using GroceryApp.Services.Location;
using GroceryApp.Services.Navigation;
using GroceryApp.Services.ShareInfo;
using GroceryApp.ViewModels;
using GroceryApp.Views;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using UraniumUI;

namespace GroceryApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()               
                .UseUraniumUI()
                .UseUraniumUIMaterial()              
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<ILocationService, LocationService>();
            builder.Services.AddSingleton<IShareInfoService, ShareInfoService>();
            
            builder.Services.AddSingleton<IProductsService>(
                sp =>
                {
                    return new ProductsService(new Uri($"https://meijer-maui-test-default-rtdb.firebaseio.com/"));
                });
            builder.Services.AddSingleton<ProductsListViewModel>();
            builder.Services.AddSingleton<ProductShowViewModel>();
            builder.Services.AddSingleton<ProductsListView>();
            builder.Services.AddSingleton<ProductShowView>();
            return builder.Build();
        }
    }
}
