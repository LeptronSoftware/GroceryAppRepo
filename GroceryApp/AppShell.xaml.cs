using GroceryApp.Views;

namespace GroceryApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeRouting();
            InitializeComponent();
        }
        private static void InitializeRouting()
        {

            Routing.RegisterRoute("ProductsListView", typeof(ProductsListView));
            Routing.RegisterRoute("ProductShowView", typeof(ProductShowView));
        }
    }
}
