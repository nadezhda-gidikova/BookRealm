using BookRealm.Data.Models;
using BookRealm.Services.Mapping;
using BookRealm.ViewModels.Authors;
using BookRealm.ViewModels.Genres;
using BookRealm.ViewModels.Reviews;

namespace BookRealm.ViewModels.Books
{
    public class BookViewModel:IMapFrom<Book>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public DateTime DateOfPublish { get; set; }
        public string CoverUrl { get; set; }
        public ICollection<AuthorViewModel> Authors { get; set; } = new HashSet<AuthorViewModel>();
        public ICollection<ReviewViewModel> Reviews { get; set; } = new HashSet<ReviewViewModel>();
        public ICollection<GenreViewModel> Genres { get; set; } = new HashSet<GenreViewModel>();
    }
}
