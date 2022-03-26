public class LibraryRepository : ILibraryRepository
{
    public void AddBook(Book book)
    {
        DataStore.books.Add(book);
    }

    public void AddBookWriter(BookWriter bookWriter)
    {
        DataStore.writers.Add(bookWriter);
    }

    public void AddLibrarian(Librarian librarian)
    {
        DataStore.librarians.Add(librarian);
    }

    public void AddMember(Member member)
    {
        DataStore.members.Add(member);
    }

    public List<Article>? GetArticles()
    {
        var books = DataStore.books.FindAll(b => b.Role == Roles.article);
        List<Article> articles = new List<Article>(); 
        foreach (var book in books) // unboxing 
        {
            articles.Add((Article)book);
        }
        return articles;
    }

    public Book? GetBook(string name)
    {
        return DataStore.books.FirstOrDefault(b => b.name == name);
    }

    public List<Book>? GetBooks()
    {
        return DataStore.books;
    }

    public List<BookWriter> GetBookWriters()
    {
        return DataStore.writers;
    }

    public Librarian? GetLibrarian(int id)
    {
        return DataStore.librarians.FirstOrDefault(l => l.librarianID == id);
    }

    public List<Librarian>? GetLibrarians()
    {
        return DataStore.librarians;
    }

    public Member? GetMember(int id)
    {
        return DataStore.members.FirstOrDefault(m => m.memeberID == id);
    }

    public List<Member>? GetMembers()
    {
        return DataStore.members;
    }

    public List<Researches>? GetResearches()
    {
        var books = DataStore.books.FindAll(b => b.Role == Roles.researches);
        List<Researches> researches = new List<Researches>();
        foreach (var book in books) // unboxing 
        {
            researches.Add((Researches)book);
        }
        return researches;
    }

    public List<ScienceBook>? GetScienceBooks()
    {
        var books = DataStore.books.FindAll(b => b.Role == Roles.scienceBook);
        List<ScienceBook> scienceBooks = new List<ScienceBook>();
        foreach (var book in books) // unboxing 
        {
            scienceBooks.Add((ScienceBook)book);
        }
        return scienceBooks;
    }

    public List<StoryBook>? GetStoryBooks()
    {
        var books = DataStore.books.FindAll(b => b.Role == Roles.storyBook);
        List<StoryBook> storyBooks = new List<StoryBook>();
        foreach (var book in books) // unboxing 
        {
            storyBooks.Add((StoryBook)book);
        }
        return storyBooks;
    }

    public List<Thesis>? GetThesis()
    {
        var books = DataStore.books.FindAll(b => b.Role == Roles.thesis);
        List<Thesis> theses = new List<Thesis>();
        foreach (var book in books) // unboxing 
        {
            theses.Add((Thesis)book);
        }
        return theses;
    }

    public void SaveChanges(List<Book> books, List<Librarian> librarians, List<Member> members)
    {
        DataStore.books = books;
        DataStore.librarians = librarians;
        DataStore.members = members;
    }

    public void SaveChanges(List<Book> books, List<Librarian> librarians, List<Member> members, List<BookWriter> writers)
    {
        DataStore.books = books;
        DataStore.librarians = librarians;
        DataStore.members = members;
        DataStore.writers = writers;
    }
}