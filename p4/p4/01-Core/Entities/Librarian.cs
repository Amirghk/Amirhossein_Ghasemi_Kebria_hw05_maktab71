public class Librarian // +
{
    public string firstName;
    public string lastName;
    public int librarianID;
    public Librarian(string firstName, string lastName, int librarianID)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.librarianID = librarianID;
    }

    public override string ToString()
    {
        return $"-- {firstName} {lastName} // ID: {librarianID}";
    }
}