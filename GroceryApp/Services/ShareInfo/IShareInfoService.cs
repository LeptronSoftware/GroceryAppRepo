using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Services.ShareInfo
{
    public interface IShareInfoService
    {
        public Task ShareInfo(string title, string info);
    }
}
