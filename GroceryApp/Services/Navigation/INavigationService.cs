﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Services.Navigation
{
    public interface INavigationService
    {      
        Task NavigateToAsync(string route, IDictionary<string, object>? routeParameters = null);

        Task PopAsync();
    }
}
