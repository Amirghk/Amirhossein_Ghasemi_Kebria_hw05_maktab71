public class Library // +
{
    public string name;
    public List<Book> books;
    // public List<Book> borrowedBooks;
    public List<Librarian> librarians;
    public List<Member> members;
    public List<BookWriter> writers;

    public Library(string name)
    {
        this.name = name;
    }

    public void AddBook(Book book)
    {
        if (books == null)
            books = new List<Book> { book };
        else
            books.Add(book);
    }

    public void DeleteBook(Book book)
    {
        books.Remove(book);
    }

    public void AddBorrowedBooks(Book borrowedBook, Member member, LibraryDate borrowedDate)
    {
        borrowedBook.borrowed = member;
        borrowedBook.borrowedDate = borrowedDate;
        if (books == null)
        {
            books = new List<Book>
            {
                borrowedBook,
            };
        }
        else
        {
            books.Find(b => b.name == borrowedBook.name).borrowed = member;
            books.Find(b => b.name == borrowedBook.name).borrowedDate = borrowedDate;
        }
            
            
    }

    public void DeleteBorrowedBook(Book borrowedBook, LibraryDate returnDate)
    {
        int daysBorrowed = returnDate - borrowedBook.borrowedDate;
        if (daysBorrowed > 7)
        {
            borrowedBook.borrowed.penalties += daysBorrowed * 500;
            Console.WriteLine($"Your return penalty is {borrowedBook.borrowed.penalties} Tomans!");
        }
            
        borrowedBook.borrowed = null;
        borrowedBook.borrowedDate = null;
        books.Find(b => b.name == borrowedBook.name).borrowed = null;
        books.Find(b => b.name == borrowedBook.name).borrowedDate = null;
    }

    public void GetBooks()
    {
        foreach (var item in books)
        {
            Console.WriteLine($"-- {item.name}");
        }
    }

    public void GetBorrowedBooks()
    {
        var borrowedBooks = books.FindAll(x => x.borrowed != null);
        if (borrowedBooks == null)
            Console.WriteLine("No books borrowed yet!");
        else
        {
            foreach (var item in borrowedBooks)
            {
                Console.WriteLine($"-- {item.name}");
            }
        }
        
    } // try catch didn't work here

    public void GetAvailableBooks()
    {
        var availableBooks = books.FindAll(x => x.borrowed == null);
        foreach (var book in availableBooks)
            Console.WriteLine($"-- {book.name}");
    }

    public void AddLibrarian(Librarian librarian)
    {
        if (librarians == null)
            librarians = new List<Librarian> { librarian };
        else
            librarians.Add(librarian);
    }

    public void GetLibrarians()
    {
        foreach (var item in librarians)
        {
            Console.WriteLine(item);
        }
    }

    public void DeleteLibrarian(Librarian librarian)
    {
        librarians.Remove(librarian);
    }

    public void AddMember(Member member)
    {
        if (members == null)
            members = new List<Member> { member};
        else
            members.Add(member);
    }

    public void GetMembers()
    {
        foreach (var item in members)
        {
            Console.WriteLine(item);
        }
    }

    public void DeleteMember(Member member)
    {
        members.Remove(member);
    }
}
