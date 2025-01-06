using CommunityToolkit.Mvvm.Input;
using GroceryApp.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.ViewModels.Base
{
    public interface IViewModelBase : IQueryAttributable
    {
        public INavigationService NavigationService { get; }
        public IAsyncRelayCommand InitializeAsyncCommand { get; }
    }
}
