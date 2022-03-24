public class StoryBook : Book // +
{
    public string style;
    public override Roles Role => Roles.storyBook;
    public StoryBook(string name, BookWriter writer, string style) : base (name, writer)
    {
        this.style = style;
    }
    
    public new void GetInfo()
    {
        Console.WriteLine($"{name} Writer: {writer.firstName} {writer.lastName} Style: {style}");
    }
}