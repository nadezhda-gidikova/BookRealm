namespace BookRealm.Data.Models
{
    public class BookGenre
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
