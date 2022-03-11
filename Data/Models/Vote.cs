using BookRealm.Data.Common.Models;

namespace BookRealm.Data.Models
{
    public class Vote: BaseDeletableModel<int>
    {
        public string BookId { get; set; }
        public Book Book { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int Value { get; set; }
    }
}
