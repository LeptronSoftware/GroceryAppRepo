using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GroceryApp.Models
{
    public class Product
    {
        public int id { get; set; }
        public string? imageUrl { get; set; }       
        public string? summary { get; set; }
        public string? title { get; set; }
    }
}
