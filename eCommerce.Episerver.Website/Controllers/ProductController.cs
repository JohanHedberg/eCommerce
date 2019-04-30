using eCommerce.Episerver.Website.Models.Catalog;
using eCommerce.Episerver.Website.ViewModels;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace eCommerce.Episerver.Website.Controllers
{
    public class ProductController : ContentController<Product>
    {
        public ActionResult Index(Product currentContent)
        {
            var viewModel = new ProductViewModel(currentContent);
            return View(viewModel);
        }
    }
}