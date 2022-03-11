using BookRealm.Data.Models;
using BookRealm.Services.Mapping;

namespace BookRealm.ViewModels.Genres
{
    public class GenreViewModel:IMapFrom<BookGenre>
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
    }
}
