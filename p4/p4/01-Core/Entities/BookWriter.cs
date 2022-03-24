public class BookWriter
{
    public string firstName;
    public string lastName;
    List<Book> books;

    public BookWriter(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public void GetBooks()
    {
        foreach (var item in books)
        {
            Console.WriteLine($"");
        }
    }

    public void AddWrittenBooks(Book book)
    {
        // TODO
    }
}