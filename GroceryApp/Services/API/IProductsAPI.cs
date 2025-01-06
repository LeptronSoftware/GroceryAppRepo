using GroceryApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Services.API
{
 
    [Headers("Content-Type: application/json")]
    public interface IProductsAPI
    {
        [Get("/products.json")]
        Task<List<Product>> GetProducts();

        [Get("/product-details/{id}.json")]
        Task<ProductDetail> GetProductDetail(int id);
    }
    
}
