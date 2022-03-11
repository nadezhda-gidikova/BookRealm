using BookRealm.Data.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace BookRealm.Data.Models
{
    public class Book:BaseDeletableModel<string>
    {
        public Book()
        {
            Id = Guid.NewGuid().ToString();
        }
        
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public double Rating { get; set; }
        public DateTime DateOfPublish { get; set; }
        public string CoverUrl { get; set; }
        public ICollection<AuthorBook> Authors { get; set; } = new HashSet<AuthorBook>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public ICollection<BookGenre> Genres { get; set; } = new HashSet<BookGenre>();




    }
}
