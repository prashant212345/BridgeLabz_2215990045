using System;

public class Book
{
    // Fields
    private string title;
    private string author;
    private double price;

    // Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

// Main Class to Test
public class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 399.99);
        book1.DisplayDetails();
    }
}
