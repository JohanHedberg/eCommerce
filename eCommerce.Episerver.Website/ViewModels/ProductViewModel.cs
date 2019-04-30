using eCommerce.Episerver.Website.Models.Catalog;

namespace eCommerce.Episerver.Website.ViewModels
{
    public class ProductViewModel : ContentViewModel<Product>
    {
        public ProductViewModel(Product content) : base(content)
        {

        }
    }
}