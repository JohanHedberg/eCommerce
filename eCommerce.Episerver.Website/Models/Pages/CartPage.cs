using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace eCommerce.Episerver.Website.Models.Pages
{
    [ContentType(
        DisplayName = "CartPage",
        GUID = "5dc062da-56c2-497a-a449-61493011c518",
        Description = ""
        )]
    public class CartPage : PageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */

        public virtual ContentReference CheckoutPage { get; set; }

    }
}