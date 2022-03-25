using Newtonsoft.Json;
public class LibraryRepoFile : ILibraryRepository
{
    string booksAddress = @".\books.txt";
    string membersAddress = @".\members.txt";
    string librariansAddress = @".\librarians.txt";
    string writersAddress = @".\writers.txt";
    
    //
    

    public void AddBook(Book book)
    {
        // deserialize txt file to a list
        var books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(booksAddress));
        books.Add(book); // add the item to the list

        // serialize the list and write it into the file
        string output = JsonConvert.SerializeObject(books);
        File.WriteAllText(booksAddress, output);
    }

    public void AddBookWriter(BookWriter bookWriter)
    {
        var writers = JsonConvert.DeserializeObject<List<BookWriter>>(File.ReadAllText(writersAddress));
        writers.Add(bookWriter);

        string output = JsonConvert.SerializeObject(writers);
        File.WriteAllText(writersAddress, output);
    }

    public void AddLibrarian(Librarian librarian)
    {
        var librarians = JsonConvert.DeserializeObject<List<Librarian>>(File.ReadAllText(librariansAddress));
        librarians.Add(librarian);

        string output = JsonConvert.SerializeObject(librarians);
        File.WriteAllText(librariansAddress, output);
    }

    public void AddMember(Member member)
    {
        var members = JsonConvert.DeserializeObject<List<Member>>(File.ReadAllText(membersAddress));
        members.Add(member);

        string output = JsonConvert.SerializeObject(members);
        File.WriteAllText(membersAddress, output);
    }

    public List<Article> GetArticles()
    {
        // deserialize txt file into list
        var books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(booksAddress));
        var articles = books.FindAll(b => b.Role == Roles.article); // find all the books that are articles
        List<Article> articlesList = new(); // make a new article list

        foreach (var article in articlesList) 
        {
            articles.Add((Article) article); // unbox books into articles and add to the list
        }
        return articlesList; // return list
    }

    public Book? GetBook(string name)
    {
        var books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(booksAddress));
        return books.FirstOrDefault(b => b.name == name);
    }

    public List<Book> GetBooks()
    {
        return JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(booksAddress));
    }

    public List<BookWriter> GetBookWriters()
    {
        return JsonConvert.DeserializeObject<List<BookWriter>>(File.ReadAllText(writersAddress));
    }

    public Librarian? GetLibrarian(int id)
    {
        var librarians = JsonConvert.DeserializeObject<List<Librarian>>(File.ReadAllText(librariansAddress));
        return librarians.FirstOrDefault(l => l.librarianID == id);
    }

    public List<Librarian> GetLibrarians()
    {
        return JsonConvert.DeserializeObject<List<Librarian>>(File.ReadAllText(librariansAddress));
    }

    public Member? GetMember(int id)
    {
        var members = JsonConvert.DeserializeObject<List<Member>>(File.ReadAllText(membersAddress));
        return members.FirstOrDefault(m => m.memeberID == id);
    }

    public List<Member>? GetMembers()
    {
        return JsonConvert.DeserializeObject<List<Member>>(File.ReadAllText(membersAddress));
    }

    public List<Researches>? GetResearches()
    {
        var books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(booksAddress));
        var researches = books.FindAll(b => b.Role == Roles.researches);
        List<Researches> res = new List<Researches>();
        foreach (var item in researches)
        {
            res.Add((Researches)item);
        }
        return res;
    }

    public List<ScienceBook> GetScienceBooks()
    {
        var books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(booksAddress));
        var scienceBooks = books.FindAll(b => b.Role == Roles.scienceBook);
        List<ScienceBook> scb = new List<ScienceBook>();
        foreach (var item in scienceBooks)
        {
            scb.Add((ScienceBook)item);
        }
        return scb;
    }

    public List<StoryBook> GetStoryBooks()
    {
        var books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(booksAddress));
        var storyBooks = books.FindAll(b => b.Role == Roles.storyBook);
        List<StoryBook> sb = new List<StoryBook>();
        foreach (var item in storyBooks)
        {
            sb.Add((StoryBook)item);
        }
        return sb;
    }

    public List<Thesis> GetThesis()
    {
        var books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(booksAddress));
        var theses = books.FindAll(b => b.Role == Roles.thesis);
        List<Thesis> th = new List<Thesis>();
        foreach (var item in theses)
        {
            th.Add((Thesis)item);
        }
        return th;
    }

    public void SaveChanges(List<Book> books, List<Librarian> librarians, List<Member> members, List<BookWriter> writers)
    {
        string outputBooks = JsonConvert.SerializeObject(books);
        string outputLibrarians = JsonConvert.SerializeObject(librarians);
        string outputMembers = JsonConvert.SerializeObject(members);
        string outputWriters = JsonConvert.SerializeObject(writers);

        File.WriteAllText(booksAddress, outputBooks);
        File.WriteAllText(membersAddress, outputMembers);
        File.WriteAllText(librariansAddress, outputLibrarians);
        File.WriteAllText(writersAddress, outputWriters);
    }
}