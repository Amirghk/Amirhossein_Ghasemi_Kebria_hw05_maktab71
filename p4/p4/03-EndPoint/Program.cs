using Newtonsoft.Json;


ILibraryRepository DATA = new LibraryRepository();
Library library = new("Library");
// add everything to library for caching
library.members = DATA.GetMembers();
library.librarians = DATA.GetLibrarians();
library.writers = DATA.GetBookWriters();
library.books = DATA.GetBooks();


// json convert settings to ot be stuck in infinite loop
JsonConvert.DefaultSettings = () => new JsonSerializerSettings
{
    Formatting = Newtonsoft.Json.Formatting.Indented,
    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
};


MainMenu();

void MainMenu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1 - Add a member.");
        Console.WriteLine("2 - Add a librarian.");
        Console.WriteLine("3 - Add a writer.");
        Console.WriteLine("4 - Add a book.");
        Console.WriteLine("5 - borrow a book.");
        Console.WriteLine("6 - return a book.");
        Console.WriteLine("7 - Exit.");
        var choice = Console.ReadKey(true);
        switch (choice.Key)
        {
            case ConsoleKey.D1:
                AddMember();
                break;
            case ConsoleKey.D2:
                AddLibrarian();
                break;
            case ConsoleKey.D3:
                AddWriter();
                break;
            case ConsoleKey.D4:
                AddBook();
                break;
            case ConsoleKey.D5:
                BorrowBook();
                break;
            case ConsoleKey.D6:
                ReturnBook();
                break;
            case ConsoleKey.D7:
                return;
            default:
                Console.WriteLine("Wrong Input!");
                break;
        }
        // save everychange made to library lists to file or ram
        DATA.SaveChanges(library.books, library.librarians, library.members, library.writers);
    }
}



void AddMember() 
{
    int id = 0;
    string first;
    string last;
    Console.WriteLine("Enter first name: ");
    first = Console.ReadLine();
    Console.WriteLine("Enter last name: ");
    last = Console.ReadLine();
    bool loop = true;
    while (loop)
    {
        Console.WriteLine("Enter ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        if (DATA.GetMembers().FirstOrDefault(m => m.memeberID == id) != null)
        {
            Console.WriteLine("ID already exists!");
        }
        else 
            loop = false;
    }

    Member member = new Member(first, last, id);
    library.AddMember(member);

    Console.WriteLine("Press any key to continue");
    Console.ReadKey(true);
} // +

void AddLibrarian() 
{
    int id = 0;
    string first;
    string last;
    Console.WriteLine("Enter first name: ");
    first = Console.ReadLine();
    Console.WriteLine("Enter last name: ");
    last = Console.ReadLine();
    bool loop = true;
    while (loop)
    {
        Console.WriteLine("Enter ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        if (DATA.GetLibrarians().FirstOrDefault(l => l.librarianID == id) != null)
        {
            Console.WriteLine("ID already exists!");
        }
        else
            loop = false;
    }

    Librarian librarian = new Librarian(first, last, id);
    library.AddLibrarian(librarian);

    Console.WriteLine("Press any key to continue");
    Console.ReadKey(true);
} // +

void AddWriter() 
{
    string first;
    string last;
    Console.WriteLine("Enter first name: ");
    first = Console.ReadLine();
    Console.WriteLine("Enter last name: ");
    last = Console.ReadLine();
    
    BookWriter writer = new(first, last);
    library.writers.Add(writer);

    Console.WriteLine("Press any key to continue");
    Console.ReadKey(true);
} // +

void AddBook() 
{
    Console.WriteLine("What kind of book would you like to add?");
    Console.WriteLine("1 - StoryBook");
    Console.WriteLine("2 - ScienceBook");
    Console.WriteLine("3 - Research");
    Console.WriteLine("4 - Article");
    Console.WriteLine("5 - Thesis");
    string? name;
    BookWriter? writer;
    ConsoleKeyInfo key;
    var choice = Console.ReadKey(true);
    switch (choice.Key)
    {
        case ConsoleKey.D1: // StoryBook
            Console.WriteLine("Enter the name of the book:");
            name = Console.ReadLine();
            Console.WriteLine("1 - Add a new writer.");
            Console.WriteLine("2 - Choose from an existing writer.");
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1: 
                    AddWriter();
                    writer = library.writers[^1];
                    break;
                case ConsoleKey.D2:
                    var writers = DATA.GetBookWriters();
                    Console.WriteLine("Select a writer: ");
                    foreach (BookWriter w in writers)
                    {
                        Console.WriteLine($"{writers.IndexOf(w)} - {w.firstName} {w.lastName}");
                    }
                    var k = Convert.ToInt32(Console.ReadLine());
                    writer = writers[k];                    
                    break;
                default:
                    writer = library.writers[^1];
                    break;
            }
            Console.WriteLine("What Style is the book written in?");
            string style = Console.ReadLine();
            StoryBook sb = new(name , writer, style);
            library.AddBook(sb);
            break;
        case ConsoleKey.D2: // ScienceBook
            Console.WriteLine("Enter the name of the book:");
            name = Console.ReadLine();
            Console.WriteLine("1 - Add a new writer.");
            Console.WriteLine("2 - Choose from an existing writer.");
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    AddWriter();
                    writer = library.writers[^1];
                    break;
                case ConsoleKey.D2:
                    var writers = DATA.GetBookWriters();
                    Console.WriteLine("Select a writer: ");
                    foreach (BookWriter w in writers)
                    {
                        Console.WriteLine($"{writers.IndexOf(w)} - {w.firstName} {w.lastName}");
                    }
                    var k = Convert.ToInt32(Console.ReadLine());
                    writer = writers[k];
                    break;
                default:
                    writer = library.writers[^1];
                    break;
            }
            Console.WriteLine("What Scientific field does this book relate to?");
            string sField = Console.ReadLine();
            ScienceBook scb = new(name, writer, sField);
            library.AddBook(scb);
            break;
        case ConsoleKey.D3: // Research
            Console.WriteLine("Enter the name of the book:");
            name = Console.ReadLine();
            Console.WriteLine("1 - Add a new writer.");
            Console.WriteLine("2 - Choose from an existing writer.");
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    AddWriter();
                    writer = library.writers[^1];
                    break;
                case ConsoleKey.D2:
                    var writers = DATA.GetBookWriters();
                    Console.WriteLine("Select a writer: ");
                    foreach (BookWriter w in writers)
                    {
                        Console.WriteLine($"{writers.IndexOf(w)} - {w.firstName} {w.lastName}");
                    }
                    var k = Convert.ToInt32(Console.ReadLine());
                    writer = writers[k];
                    break;
                default:
                    writer = library.writers[^1];
                    break;
            }
            Console.WriteLine("What university was this research done in?");
            string uni = Console.ReadLine();
            Researches res = new(name, writer, uni);
            library.AddBook(res);
            break;
        case ConsoleKey.D4: // Article
            Console.WriteLine("Enter the name of the book:");
            name = Console.ReadLine();
            Console.WriteLine("1 - Add a new writer.");
            Console.WriteLine("2 - Choose from an existing writer.");
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    AddWriter();
                    writer = library.writers[^1];
                    break;
                case ConsoleKey.D2:
                    var writers = DATA.GetBookWriters();
                    Console.WriteLine("Select a writer: ");
                    foreach (BookWriter w in writers)
                    {
                        Console.WriteLine($"{writers.IndexOf(w)} - {w.firstName} {w.lastName}");
                    }
                    var k = Convert.ToInt32(Console.ReadLine());
                    writer = writers[k];
                    break;
                default:
                    writer = library.writers[^1];
                    break;
            }
            Console.WriteLine("What university was this research done in?");
            uni = Console.ReadLine();
            Console.WriteLine("Enter the name of the journal: ");
            string journal = Console.ReadLine();
            Console.WriteLine("Enter the year this article was published: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Article art = new(name, writer, uni, journal, year);
            library.AddBook(art);
            break;
        case ConsoleKey.D5: // Thesis
            Console.WriteLine("Enter the name of the book:");
            name = Console.ReadLine();
            Console.WriteLine("1 - Add a new writer.");
            Console.WriteLine("2 - Choose from an existing writer.");
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    AddWriter();
                    writer = library.writers[^1];
                    break;
                case ConsoleKey.D2:
                    var writers = DATA.GetBookWriters();
                    Console.WriteLine("Select a writer: ");
                    foreach (BookWriter w in writers)
                    {
                        Console.WriteLine($"{writers.IndexOf(w)} - {w.firstName} {w.lastName}");
                    }
                    var k = Convert.ToInt32(Console.ReadLine());
                    writer = writers[k];
                    break;
                default:
                    writer = library.writers[^1];
                    break;
            }
            Console.WriteLine("What university was this research done in?");
            uni = Console.ReadLine();

            Console.WriteLine("Enter the name of the assisting professor: ");
            string proff = Console.ReadLine();
            Thesis th = new(name, writer, uni, proff);
            library.AddBook(th);
            break;
        default:
            Console.WriteLine("Wrong Input!");
            break;
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey(true);
}// +

void BorrowBook()
{
    Console.WriteLine("Enter your member ID: ");
    int id = Convert.ToInt32(Console.ReadLine());
    List<Member>? members = DATA.GetMembers();
    var user = members.FirstOrDefault(m => m.memeberID == id);
    if (user == null)
    {
        Console.WriteLine("ID is incorrect!");
    }
    else
    {
        Console.WriteLine("Which book would you like to borrow:");
        library.GetAvailableBooks(); // prints all available books
        string? choice = Console.ReadLine();
        var book = library.books.FirstOrDefault(b => b.name == choice);
        if (book == null)
        {
            Console.WriteLine($"No book named {choice} exists!");
            return;
        }
            
        int day = DateTime.Now.Day;
        if (day > 30) // if day was 31 lower it to 30 because thats how the libraryDate class works
            day = 30;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        library.AddBorrowedBooks(book, user, new(day, month, year));
        if (user.books == null)
        {
            user.books = new List<Book> {
            book,
        };
        }
        else
        {
            user.books.Add(book);
        }
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey(true);
} // +

void ReturnBook()
{
    
    

    library.GetBorrowedBooks();
    Console.WriteLine("What book would you like to return: ");

    string? choice = Console.ReadLine();
    var book = library.books.FirstOrDefault(b => b.name == choice);
    if (book == null)
    {
        Console.WriteLine($"No book named {choice} exists!");
        return;
    }
    Console.WriteLine("Day: ");
    int day = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Month: ");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Year: ");
    int year = Convert.ToInt32(Console.ReadLine());

    var user = book.borrowed; // find out who the user was that borrowed the book

    library.DeleteBorrowedBook(book, new(day, month, year));
    user.books.Remove(book); // remove the book from the user's books list
    user.penalties = 0;

    Console.WriteLine("Press any key to continue");
    Console.ReadKey(true);
}
