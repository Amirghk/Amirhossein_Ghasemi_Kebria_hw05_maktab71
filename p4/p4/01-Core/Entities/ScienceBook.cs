public class ScienceBook : Book // +
{
    string scienceField;

    public ScienceBook(string name, BookWriter writer, string scienceField) : base (name, writer)
    {
        this.scienceField = scienceField;
    }

    public new void GetInfo()
    {
        Console.WriteLine($"{name} Writer: {writer.firstName} {writer.lastName} Field: {scienceField}");
    }
}