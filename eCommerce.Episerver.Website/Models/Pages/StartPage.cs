using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Episerver.Website.Models.Pages
{
    [ContentType(
        DisplayName = "Start Page",
        GUID = "3776bd8b-eb5b-4899-b55e-d48bbe993612",
        Description = "The web site start page."
        )]
    public class StartPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        public virtual ContentReference CheckoutPage { get; set; }

        public virtual ContentReference Cart { get; set; }
    }
}