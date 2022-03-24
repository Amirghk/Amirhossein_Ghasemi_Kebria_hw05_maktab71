public interface ILibraryRepository
{
    public List<Book> GetBooks();
    public List<Member> GetMembers();
    public List<Librarian> GetLibrarians();
    public Member GetMember(int id);
    public Librarian GetLibrarian(int id);
    public Book GetBook(string name);
    public void AddBook(Book book);
    public void AddMember(Member member);
    public void AddLibrarian(Librarian librarian);



    //Save changes
    public void SaveChanges(List<Book> books, List<Librarian> librarians, List<Member> members);

}