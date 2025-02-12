using System;

class BookNode
{
    public int BookID;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;
    public BookNode Prev;
    public BookNode Next;

    public BookNode(int bookID, string title, string author, string genre, bool isAvailable)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Prev = null;
        Next = null;
    }
}

class Library
{
    private BookNode head = null;
    private BookNode tail = null;

    // Add book at the beginning
    public void AddAtBeginning(int bookID, string title, string author, string genre, bool isAvailable)
    {
        BookNode newBook = new BookNode(bookID, title, author, genre, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        Console.WriteLine("Book added at the beginning.");
    }

    // Add book at the end
    public void AddAtEnd(int bookID, string title, string author, string genre, bool isAvailable)
    {
        BookNode newBook = new BookNode(bookID, title, author, genre, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        Console.WriteLine("Book added at the end.");
    }

    // Remove book by Book ID
    public void RemoveBook(int bookID)
    {
        if (head == null)
        {
            Console.WriteLine("No books in library.");
            return;
        }

        BookNode temp = head;
        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp == head)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
        }
        else if (temp == tail)
        {
            tail = tail.Prev;
            if (tail != null) tail.Next = null;
        }
        else
        {
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }

        Console.WriteLine("Book removed successfully.");
    }

    // Search book by Title
    public void SearchByTitle(string title)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Title.ToLower() == title.ToLower())
            {
                Console.WriteLine($"Book Found: ID={temp.BookID}, Title={temp.Title}, Author={temp.Author}, Genre={temp.Genre}, Available={temp.IsAvailable}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Update book availability status
    public void UpdateAvailability(int bookID, bool newStatus)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = newStatus;
                Console.WriteLine("Book availability updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Display books in forward order
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("\nLibrary Book List (Forward Order):");
        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
            temp = temp.Next;
        }
    }

    // Display books in reverse order
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("\nLibrary Book List (Reverse Order):");
        BookNode temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
            temp = temp.Prev;
        }
    }

    // Count total number of books
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        Console.WriteLine($"Total Number of Books: {count}");
    }
}

class LibraryManage
{
    static void Main()
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book at Beginning");
            Console.WriteLine("2. Add Book at End");
            Console.WriteLine("3. Remove Book by ID");
            Console.WriteLine("4. Search Book by Title");
            Console.WriteLine("5. Update Book Availability");
            Console.WriteLine("6. Display Books (Forward)");
            Console.WriteLine("7. Display Books (Reverse)");
            Console.WriteLine("8. Count Total Books");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book ID: ");
                    int bookID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Book Title: ");
                    string title1 = Console.ReadLine();
                    Console.Write("Enter Author Name: ");
                    string author1 = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    string genre1 = Console.ReadLine();
                    Console.Write("Is the book available? (true/false): ");
                    bool available1 = Convert.ToBoolean(Console.ReadLine());

                    library.AddAtBeginning(bookID1, title1, author1, genre1, available1);
                    break;

                case 2:
                    Console.Write("Enter Book ID: ");
                    int bookID2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Book Title: ");
                    string title2 = Console.ReadLine();
                    Console.Write("Enter Author Name: ");
                    string author2 = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    string genre2 = Console.ReadLine();
                    Console.Write("Is the book available? (true/false): ");
                    bool available2 = Convert.ToBoolean(Console.ReadLine());

                    library.AddAtEnd(bookID2, title2, author2, genre2, available2);
                    break;

                case 3:
                    Console.Write("Enter Book ID to remove: ");
                    int removeID = Convert.ToInt32(Console.ReadLine());
                    library.RemoveBook(removeID);
                    break;

                case 4:
                    Console.Write("Enter Book Title to search: ");
                    string searchTitle = Console.ReadLine();
                    library.SearchByTitle(searchTitle);
                    break;

                case 5:
                    Console.Write("Enter Book ID to update availability: ");
                    int updateID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter new availability status (true/false): ");
                    bool newStatus = Convert.ToBoolean(Console.ReadLine());
                    library.UpdateAvailability(updateID, newStatus);
                    break;

                case 6:
                    library.DisplayForward();
                    break;

                case 7:
                    library.DisplayReverse();
                    break;

                case 8:
                    library.CountBooks();
                    break;

                case 9:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
