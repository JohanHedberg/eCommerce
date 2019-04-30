using EPiServer.Core;

namespace eCommerce.Episerver.Website.ViewModels
{
    public abstract class ContentViewModel<T> where T : IContent
    {
        public T Content { get; set; }

        public ContentViewModel(T content)
        {
            Content = content;
        }
    }
}