using GroceryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Services.API
{
    public interface IProductsService
    {
        public Task<List<Product>> GetProducts();
        public Task<ProductDetail> GetProductDetail(int id);
    }
}
