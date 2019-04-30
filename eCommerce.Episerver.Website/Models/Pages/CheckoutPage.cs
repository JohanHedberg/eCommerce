using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace eCommerce.Episerver.Website.Models.Pages
{
    [ContentType(
        DisplayName = "CheckoutPage",
        GUID = "cec190be-78d4-43f7-a7fc-37b8739f0493",
        Description = ""
        )]
    public class CheckoutPage : PageData
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
    }
}