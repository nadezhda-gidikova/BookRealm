namespace BookRealm.Services
{
    public interface IDataGatherer
    {
        Task ImportBooksAsync(int fromId = 1, int toId = 2);
    }
}