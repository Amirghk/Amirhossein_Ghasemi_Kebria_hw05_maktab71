public interface ILibraryRepository
{
    public List<Book>? GetBooks();
    public List<ScienceBook>? GetScienceBooks();
    public List<StoryBook>? GetStoryBooks();
    public List<Researches>? GetResearches();
    public List<Thesis>? GetThesis();
    public List<Article>? GetArticles(); 
    public List<Member>? GetMembers();
    public List<Librarian>? GetLibrarians();
    public Member? GetMember(int id);
    public Librarian? GetLibrarian(int id);
    public Book? GetBook(string name);
    public void AddBook(Book book);
    public void AddMember(Member member);
    public void AddLibrarian(Librarian librarian);
    public void AddBookWriter(BookWriter bookWriter);
    public List<BookWriter> GetBookWriters();


    //Save changes
    public void SaveChanges(List<Book> books, List<Librarian> librarians, List<Member> members, List<BookWriter> writers);

}