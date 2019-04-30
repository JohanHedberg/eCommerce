using eCommerce.Episerver.Website.Models.Pages;
using eCommerce.Episerver.Website.ViewModels;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace eCommerce.Episerver.Website.Controllers
{
    public class StartController : PageController<StartPage>
    {
        public StartController()
        {

        }

        public ActionResult Index(StartPage currentContent)
        {
            var viewModel = new StartPageViewModel { StartPage = currentContent };

            return View(viewModel);
        }
    }
}