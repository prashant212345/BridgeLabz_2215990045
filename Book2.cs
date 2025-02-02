using System;

// Book class
public class Book
{
    // Attributes of the Book class
    public string title;
    public string author;
    public decimal price;
    public bool availability;

    // Constructor to initialize book details
    public Book(string bookTitle, string bookAuthor, decimal bookPrice, bool isAvailable)
    {
        title = bookTitle;
        author = bookAuthor;
        price = bookPrice;
        availability = isAvailable;
    }

    // Method to borrow the book
    public void BorrowBook()
    {
        if (availability)
        {
            availability = false;  // Mark the book as unavailable
            Console.WriteLine($"You have successfully borrowed the book '{title}' by {author}.");
        }
        else
        {
            Console.WriteLine($"Sorry, the book '{title}' is currently unavailable.");
        }
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price:C}");
        Console.WriteLine($"Availability: {(availability ? "Available" : "Not Available")}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Book object
        Book book1 = new Book("1984", "George Orwell", 9.99m, true);
        Console.WriteLine("Book 1 Details:");
        book1.DisplayBookDetails();

        // Trying to borrow the book
        book1.BorrowBook();
        Console.WriteLine();

        // Displaying updated details after borrowing
        Console.WriteLine("Updated Book 1 Details:");
        book1.DisplayBookDetails();

        Console.WriteLine();

        // Creating another Book object
        Book book2 = new Book("Brave New World", "Aldous Huxley", 12.99m, false);
        Console.WriteLine("Book 2 Details:");
        book2.DisplayBookDetails();

        // Trying to borrow the unavailable book
        book2.BorrowBook();
    }
}
