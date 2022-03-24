public class Researches : Book // +
{
    public string universityName;
    public override Roles Role => Roles.researches;
    public Researches(string name, BookWriter writer, string universityName) : base (name, writer)
    {
        this.universityName = universityName;
    }

    public new void GetInfo()
    {
        Console.WriteLine($"{name} Writer: {writer.firstName} {writer.lastName} University: {universityName}");
    }
}