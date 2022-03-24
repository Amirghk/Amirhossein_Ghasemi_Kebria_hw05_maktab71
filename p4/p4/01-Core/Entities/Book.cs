public class Book // +
{
    public string name;
    public BookWriter writer;
    public Member? borrowed = null;
    public LibraryDate? borrowedDate = null;
    public Book(string name, BookWriter writer)
    {
        this.name = name;
        this.writer = writer;
    }

    public void GetWriter()
    {
        Console.WriteLine($"{writer.firstName} {writer.lastName}");
    }

    public void GetMemberBorrowed()
    {
        if (borrowed == null)
            Console.WriteLine("No one has borrowed this book!");
        else
            Console.WriteLine($"{borrowed.firstName} {borrowed.lastName}");
    }

    public void GetInfo()
    {
        Console.WriteLine($"{name} Writer: {writer.firstName} {writer.lastName}");
    }
}