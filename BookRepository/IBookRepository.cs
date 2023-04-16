namespace BookRepository
{
    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }
}

