public class Thesis : Researches // +
{
    string professor;
    public Thesis(string name, BookWriter writer, string universityName, string professor) : base (name, writer, universityName)
    {
        this.professor = professor;
    }

    public new void GetInfo()
    {
        Console.WriteLine($"{name} Writer: {writer.firstName} {writer.lastName} University: {universityName} Professor: {professor}");
    }
}