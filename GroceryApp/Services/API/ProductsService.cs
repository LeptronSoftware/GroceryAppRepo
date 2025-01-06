using __XamlGeneratedCode__;
using GroceryApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Services.API
{
    public class ProductsService : IProductsService
    {
        private readonly HttpClient _httpClient;
        private readonly IProductsAPI _theProductsApi;

        public ProductsService(Uri baseUrl)
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = baseUrl
            };
            _theProductsApi = RestService.For<IProductsAPI>(_httpClient);
        }

        public async Task<List<Product>> GetProducts()
        {          
            return await _theProductsApi.GetProducts();
        }
        public async Task<ProductDetail> GetProductDetail(int id)
        {
           
            return await _theProductsApi.GetProductDetail(id);
        }
    }
}
