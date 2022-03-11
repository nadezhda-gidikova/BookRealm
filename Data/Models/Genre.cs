using BookRealm.Data.Common.Models;

namespace BookRealm.Data.Models
{
    public class Genre: BaseDeletableModel<int>
    {
        public string Name { get; set; }
        public ICollection<BookGenre> Books { get; set; }=new HashSet<BookGenre>();
    }
}