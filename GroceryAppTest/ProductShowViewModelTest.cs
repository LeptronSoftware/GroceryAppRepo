using GroceryApp.Models;
using GroceryApp.Services.API;
using GroceryApp.Services.Navigation;
using GroceryApp.ViewModels;
using Moq;

namespace GroceryAppTest
{
    public class ProductShowViewModelTest
    {
        [Fact]
        public async Task InitProductList()
        {          
            var product0 = new Product()
            {
                imageUrl = "Some URL",
                summary = "Fresh bananas, perfect for a healthy snack.",
                title = "Bananas",
                id = 0
            };
            var product1 = new Product()
            {
                imageUrl = "Some URL",
                summary = "apples summary",
                title = "Apples",
                id = 1
            };
            var products = new List<Product> { product0, product1 };
            var productMock = new Mock<IProductsService>();
            productMock.Setup(m => m.GetProducts()).Returns(Task.FromResult(products));
            var nav = new Mock<INavigationService>();
            var model = new ProductsListViewModel(productMock.Object, nav.Object);
            await model.InitializeAsync();
            Assert.True(model.Products != null);
            Assert.True (model.Products.Count == 2);
            
        }
    }
}
