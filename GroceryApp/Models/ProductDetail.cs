using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Models
{
    public class ProductDetail
    {
        public string? description { get; set; }
        public int id { get; set; }
        public string? imageUrl { get; set; }
        public string? price { get; set; }
        public string? summary { get; set; }
        public string? title { get; set; }
    }
}
