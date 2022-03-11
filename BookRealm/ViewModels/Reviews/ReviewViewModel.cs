using BookRealm.Data.Models;
using BookRealm.Services.Mapping;

namespace BookRealm.ViewModels.Reviews
{
    public class ReviewViewModel:IMapFrom<Review>
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
