public static class DataStore
{
    public static Library library = new Library("Digital Library");
    
    public static List<BookWriter> writers = new List<BookWriter>
    {
        new BookWriter("jk", "Rowling"),
    };
    public static List<Book> books = new List<Book>
    {
        new StoryBook("Harry potter", DataStore.writers[0], "Fantasy"),

    };
    //public static List<ScienceBook> scienceBooks = new List<ScienceBook>();
    //public static List<StoryBook> storyBooks = new List<StoryBook>();
    //public static List<Researches> researches = new List<Researches>();
    //public static List<Thesis> theses = new List<Thesis>();
    //public static List<Article> articles = new List<Article>();
    public static List<Member> members = new List<Member>();
    public static List<Librarian> librarians = new List<Librarian>();
}