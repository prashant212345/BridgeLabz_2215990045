using System;
using System.Collections.Generic;

// Abstract class LibraryItem
abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;

    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration(); // Abstract method to be overridden

    public void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
}

// Interface IReservable
interface IReservable
{
    bool ReserveItem();
    bool CheckAvailability();
}

// Book class implementing IReservable
class Book : LibraryItem, IReservable
{
    private bool isAvailable;

    public Book(int itemId, string title, string author, bool isAvailable)
        : base(itemId, title, author)
    {
        this.isAvailable = isAvailable;
    }

    public override int GetLoanDuration()
    {
        return 14; // Books can be loaned for 14 days
    }

    public bool ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            return true;
        }
        return false;
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Magazine class implementing IReservable
class Magazine : LibraryItem, IReservable
{
    private bool isAvailable;

    public Magazine(int itemId, string title, string author, bool isAvailable)
        : base(itemId, title, author)
    {
        this.isAvailable = isAvailable;
    }

    public override int GetLoanDuration()
    {
        return 7; // Magazines can be loaned for 7 days
    }

    public bool ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            return true;
        }
        return false;
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// DVD class implementing IReservable
class DVD : LibraryItem, IReservable
{
    private bool isAvailable;

    public DVD(int itemId, string title, string author, bool isAvailable)
        : base(itemId, title, author)
    {
        this.isAvailable = isAvailable;
    }

    public override int GetLoanDuration()
    {
        return 5; // DVDs can be loaned for 5 days
    }

    public bool ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            return true;
        }
        return false;
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Main Class to Demonstrate Polymorphism
class Library
{
    static void Main()
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>();

        Book book1 = new Book(101, "The Great Gatsby", "F. Scott Fitzgerald", true);
        Magazine mag1 = new Magazine(201, "National Geographic", "Various Authors", true);
        DVD dvd1 = new DVD(301, "Inception", "Christopher Nolan", false);

        libraryItems.Add(book1);
        libraryItems.Add(mag1);
        libraryItems.Add(dvd1);

        foreach (LibraryItem item in libraryItems)
        {
            item.GetItemDetails();
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

            IReservable reservableItem = item as IReservable;
            if (reservableItem != null)
            {
                Console.WriteLine("Availability: " + (reservableItem.CheckAvailability() ? "Available" : "Not Available"));
                Console.WriteLine("Reservation Status: " + (reservableItem.ReserveItem() ? "Reserved Successfully" : "Reservation Failed"));
            }

            Console.WriteLine("-------------------------");
        }
    }
}
