using BookRealm.Data.Common.Models;

namespace BookRealm.Data.Models
{
    public class Review: BaseDeletableModel<int>
    {
        public string Text { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
}