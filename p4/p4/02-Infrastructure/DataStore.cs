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

    public static List<Member> members = new List<Member>();
    public static List<Librarian> librarians = new List<Librarian>();
}