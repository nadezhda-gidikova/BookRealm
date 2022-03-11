using BookRealm.Data.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace BookRealm.Data.Models
{
    public class Author:BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }
        public ICollection<AuthorBook> Books { get; set; }=new HashSet<AuthorBook>();
    }
}