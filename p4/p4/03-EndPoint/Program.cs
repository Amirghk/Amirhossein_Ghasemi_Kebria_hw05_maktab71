using Newtonsoft.Json;


ILibraryRepository DATA = new LibraryRepository();
Library library = new("Library");

// json convert settings to ot be stuck in infinite loop
JsonConvert.DefaultSettings = () => new JsonSerializerSettings
{
    Formatting = Newtonsoft.Json.Formatting.Indented,
    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
};

LibraryRepository lb = new();
var storyBooks = lb.GetStoryBooks();
while (true)
{
    MainMenu
}






void MainMenu()
{
    while (true)
    {

    
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1 - Add a member.");
        Console.WriteLine("2 - Add a librarian.");
        Console.WriteLine("3 - Add a writer.");
        Console.WriteLine("4 - Add a book.");
        Console.WriteLine("5 - borrow a book.");
        Console.WriteLine("6 - return a book.");
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
                return 4;
            case ConsoleKey.D5:
                return 5;
            case ConsoleKey.D6:
                return 6;
            default:
                Console.WriteLine("Wrong Input!");
                break;
        }
    }
}



void AddMember() // +
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
    DATA.AddMember(member);
    library.AddMember(member);
}

void AddLibrarian() // +
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
    DATA.AddLibrarian(librarian);
    library.AddLibrarian(librarian);
}

void AddWriter() // +
{
    string first;
    string last;
    Console.WriteLine("Enter first name: ");
    first = Console.ReadLine();
    Console.WriteLine("Enter last name: ");
    last = Console.ReadLine();
    
    BookWriter writer = new(first, last);
    DATA.AddBookWriter(writer);
    library.writers.Add(writer);
}

void AddBook() 
{
    Console.WriteLine("What kind of book would you like to add?");
    Console.WriteLine("1 - StoryBook");
    Console.WriteLine("2 - ScienceBook");
    Console.WriteLine("3 - Research");
    Console.WriteLine("4 - Article");
    Console.WriteLine("5 - Thesis");
    var choice = Console.ReadKey(true);
    switch (choice.Key)
    {
        case ConsoleKey.D1:
            break;
        case ConsoleKey.D2:
            break;
        case ConsoleKey.D3:
            break;
        case ConsoleKey.D4:
            break;
        case ConsoleKey.D5:
            break;
        default:
            break;
    }
}// NOT FINISHED
