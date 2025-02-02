using System;

class Book
{
    // Public: Can be accessed from anywhere
    public string ISBN;

    // Protected: Can be accessed in this class and derived classes
    protected string title;

    // Private: Can only be accessed within this class
    private string author;

    // Constructor to initialize book details
    public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // Public Method: Get Author Name
    public string GetAuthor()
    {
        return author;
    }

    // Public Method: Set Author Name
    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

    // Public Method: Display Book Details
    public void DisplayBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine();
    }
}

// Derived Class: Demonstrating use of protected and public members
class EBook : Book
{
    private double fileSizeMB;

    // Constructor
    public EBook(string ISBN, string title, string author, double fileSizeMB)
        : base(ISBN, title, author)
    {
        this.fileSizeMB = fileSizeMB;
    }

    // Method to Display EBook Details
    public void DisplayEBookDetails()
    {
        Console.WriteLine("EBook Details:");
        Console.WriteLine("ISBN: " + ISBN); // Accessing public member
        Console.WriteLine("Title: " + title); // Accessing protected member
        Console.WriteLine("File Size: " + fileSizeMB + " MB");
        Console.WriteLine();
    }
}

// Main Method
class Program
{
    static void Main()
    {
        // Creating Book Object
        Book book1 = new Book("978-3-16-148410-0", "C# Programming", "John Doe");

        // Displaying book details
        Console.WriteLine("Book Details:");
        book1.DisplayBookDetails();

        // Modifying Author Name using setter method
        book1.SetAuthor("Jane Smith");
        Console.WriteLine("After Updating Author:");
        book1.DisplayBookDetails();

        // Creating EBook Object
        EBook ebook1 = new EBook("978-0-07-212575-7", "Advanced C#", "Mark Wilson", 5.2);

        // Display EBook details
        ebook1.DisplayEBookDetails();
    }
}
