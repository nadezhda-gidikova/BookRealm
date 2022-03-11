namespace BookRealm.Data.Models
{
    public class AuthorBook
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string  BookId { get; set; }
        public Book Book { get; set; }
            
    }
}
