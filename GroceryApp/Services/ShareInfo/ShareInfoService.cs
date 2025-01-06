using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Services.ShareInfo
{
    public class ShareInfoService : IShareInfoService
    {
        public async Task ShareInfo(string title, string info)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Subject = title,
                Text = info,
                Uri = "",
                Title = title                 
            });
        }
    }
}
