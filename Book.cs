using System;

// Book class
public class Book
{
    // Attributes of the Book class
    public string title;
    public string author;
    public decimal price;

    // Default constructor (no parameters)
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
        price = 0.00m;
    }

    // Parameterized constructor (allows setting values when creating a book object)
    public Book(string bookTitle, string bookAuthor, decimal bookPrice)
    {
        title = bookTitle;
        author = bookAuthor;
        price = bookPrice;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price.ToString("C"));
    }
}

class Program
{
    static void Main()
    {
        // Creating a Book object using the default constructor
        Book book1 = new Book();
        Console.WriteLine("Book 1 (Using Default Constructor):");
        book1.DisplayBookDetails();
        
        Console.WriteLine();

        // Creating a Book object using the parameterized constructor
        Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 15.99m);
        Console.WriteLine("Book 2 (Using Parameterized Constructor):");
        book2.DisplayBookDetails();
    }
}
