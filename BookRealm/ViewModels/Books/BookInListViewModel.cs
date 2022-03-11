using AutoMapper;
using BookRealm.Data.Models;
using BookRealm.Services.Mapping;
using BookRealm.ViewModels.Authors;

namespace BookRealm.ViewModels.Books
{
    public class BookInListViewModel : IMapFrom<Book>//, IHaveCustomMappings
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public DateTime DateOfPublish { get; set; }
        public string CoverUrl { get; set; }
        public IEnumerable<AuthorViewModel> Authors { get; set; } = new HashSet<AuthorViewModel>();

        
    }
}
