using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Services.Location
{
    public interface ILocationService
    {
        public Task<string> GetCity();
    }
}
