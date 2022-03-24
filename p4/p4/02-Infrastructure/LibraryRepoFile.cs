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

    public Book GetBook(string name)
    {
        throw new NotImplementedException();
    }

    public List<Book> GetBooks()
    {
        throw new NotImplementedException();
    }

    public List<BookWriter> GetBookWriters()
    {
        throw new NotImplementedException();
    }

    public Librarian GetLibrarian(int id)
    {
        throw new NotImplementedException();
    }

    public List<Librarian> GetLibrarians()
    {
        throw new NotImplementedException();
    }

    public Member GetMember(int id)
    {
        throw new NotImplementedException();
    }

    public List<Member> GetMembers()
    {
        throw new NotImplementedException();
    }

    public List<Researches> GetResearches()
    {
        throw new NotImplementedException();
    }

    public List<ScienceBook> GetScienceBooks()
    {
        throw new NotImplementedException();
    }

    public List<StoryBook> GetStoryBooks()
    {
        throw new NotImplementedException();
    }

    public List<Thesis> GetThesis()
    {
        throw new NotImplementedException();
    }

    public void SaveChanges(List<Book> books, List<Librarian> librarians, List<Member> members)
    {
        throw new NotImplementedException();
    }
}