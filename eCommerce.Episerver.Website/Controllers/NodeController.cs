using eCommerce.Episerver.Website.Models.Catalog;
using eCommerce.Episerver.Website.ViewModels;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace eCommerce.Episerver.Website.Controllers
{
    public class NodeController : ContentController<Node>
    {
        public ActionResult Index(Node currentContent)
        {
            var viewModel = new NodeViewModel(currentContent);
            return View(viewModel);
        }
    }
}