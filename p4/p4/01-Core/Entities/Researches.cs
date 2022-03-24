public class Researches : Book // +
{
    public string universityName;
    public Researches(string name, BookWriter writer, string universityName) : base (name, writer)
    {
        this.universityName = universityName;
    }

    public new void GetInfo()
    {
        Console.WriteLine($"{name} Writer: {writer.firstName} {writer.lastName} University: {universityName}");
    }
}