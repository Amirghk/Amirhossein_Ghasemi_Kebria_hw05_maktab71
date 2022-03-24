﻿public class Library // +
{
    public string name;
    public List<Book> books;
    public List<Book> borrowedBooks;
    public List<Librarian> librarians;
    public List<Member> members;

    public Library(string name)
    {
        this.name = name;
    }

    public void AddBook(Book book)
    {
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
        borrowedBooks.Add(borrowedBook);
    }

    public void DeleteBorrowedBook(Book borrowedBook, LibraryDate returnDate)
    {
        int daysBorrowed = returnDate - borrowedBook.borrowedDate;
        if (daysBorrowed > 7)
            borrowedBook.borrowed.penalties += daysBorrowed * 500;
        borrowedBook.borrowed = null;
        borrowedBook.borrowedDate = null;
        borrowedBooks.Remove(borrowedBook);
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
        foreach (var item in borrowedBooks)
        {
            Console.WriteLine($"-- {item.name}");
        }
    }

    public void GetAvailableBooks()
    {
        var availableBooks = books.FindAll(x => x.borrowed == null);
        foreach (var book in availableBooks)
            Console.WriteLine($"-- {book.name}");
    }

    public void AddLibrarian(Librarian librarian)
    {
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