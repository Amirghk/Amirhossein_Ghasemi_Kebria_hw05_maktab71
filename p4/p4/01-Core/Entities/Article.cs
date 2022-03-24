public class Article : Researches // +
{
    public readonly string journal;
    public readonly int year;
    public override Roles Role => Roles.article;
    public Article(string name, BookWriter writer, string universityName, string journal, int year) : base (name, writer, universityName)
    {
        this.journal = journal;
        this.year = year;
    }

    public new void GetInfo()
    {
        Console.WriteLine($"{name} Writer: {writer.firstName} {writer.lastName} University: {universityName} Journal: {journal} Year: {year}");
    }
}