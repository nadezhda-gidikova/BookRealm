using BookRealm.Data.Models;
using BookRealm.Services.Mapping;

namespace BookRealm.ViewModels.Authors
{
    public class AuthorViewModel : IMapFrom<AuthorBook>
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }

}
