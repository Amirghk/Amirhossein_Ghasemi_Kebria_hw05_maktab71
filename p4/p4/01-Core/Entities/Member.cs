public class Member // +
{
    public string firstName;
    public string lastName;
    public int penalties = 0;
    public int? memeberID = null;
    List<Book>? books = null;
    public Member(string firstName, string lastName, int memberID)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.memeberID = memberID;
    }

    public void GetBorrowedBooks()
    {
        foreach (Book book in books)
            Console.WriteLine("-- " + book.name);
    }

    public int GetPenalty()
    {
        return penalties;
    }

    public override string ToString()
    {
        return $"-- {firstName} {lastName} // ID: {memeberID}";
    }

}