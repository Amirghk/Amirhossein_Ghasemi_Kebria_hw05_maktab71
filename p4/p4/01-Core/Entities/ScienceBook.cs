public class ScienceBook : Book // +
{
    
    string scienceField;
    public override Roles Role => Roles.scienceBook;
    public ScienceBook(string name, BookWriter writer, string scienceField) : base (name, writer)
    {
        this.scienceField = scienceField;
    }

    public new void GetInfo()
    {
        Console.WriteLine($"{name} Writer: {writer.firstName} {writer.lastName} Field: {scienceField}");
    }
}