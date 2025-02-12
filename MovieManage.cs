using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Next;
    public Movie Prev;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

class MovieDoublyLinkedList
{
    private Movie head;

    // Add movie at the beginning
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head != null)
        {
            newMovie.Next = head;
            head.Prev = newMovie;
        }
        head = newMovie;
        Console.WriteLine("Movie added at the beginning.");
    }

    // Add movie at the end
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = newMovie;
        }
        else
        {
            Movie temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newMovie;
            newMovie.Prev = temp;
        }
        Console.WriteLine("Movie added at the end.");
    }

    // Add movie at a specific position
    public void AddAtPosition(int position, string title, string director, int year, double rating)
    {
        if (position == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        Movie newMovie = new Movie(title, director, year, rating);
        Movie temp = head;

        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        newMovie.Next = temp.Next;
        newMovie.Prev = temp;

        if (temp.Next != null)
        {
            temp.Next.Prev = newMovie;
        }

        temp.Next = newMovie;
        Console.WriteLine($"Movie added at position {position}");
    }

    // Remove a movie by title
    public void RemoveMovie(string title)
    {
        if (head == null)
        {
            Console.WriteLine("No movies available.");
            return;
        }

        Movie temp = head;

        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        if (temp.Prev != null)
        {
            temp.Prev.Next = temp.Next;
        }
        else
        {
            head = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next.Prev = temp.Prev;
        }

        Console.WriteLine("Movie removed successfully.");
    }

    // Search movie by director or rating
    public void SearchMovie(string director = "", double rating = -1)
    {
        Movie temp = head;
        bool found = false;

        while (temp != null)
        {
            if ((director != "" && temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase)) ||
                (rating != -1 && temp.Rating == rating))
            {
                Console.WriteLine($"Movie Found: Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
        {
            Console.WriteLine("No matching movie found.");
        }
    }

    // Display all movies in forward order
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movies available.");
            return;
        }

        Movie temp = head;
        Console.WriteLine("Movie List (Forward Order):");
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Next;
        }
    }

    // Display all movies in reverse order
    public void DisplayReverse()
    {
        if (head == null)
        {
            Console.WriteLine("No movies available.");
            return;
        }

        Movie temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        Console.WriteLine("Movie List (Reverse Order):");
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Prev;
        }
    }

    // Update movie rating
    public void UpdateRating(string title, double newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                temp.Rating = newRating;
                Console.WriteLine("Movie rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found.");
    }
}

class MovieManage
{
    static void Main()
    {
        MovieDoublyLinkedList movieList = new MovieDoublyLinkedList();

        while (true)
        {
            Console.WriteLine("\nMovie Management System");
            Console.WriteLine("1. Add Movie at Beginning");
            Console.WriteLine("2. Add Movie at End");
            Console.WriteLine("3. Add Movie at Position");
            Console.WriteLine("4. Remove Movie by Title");
            Console.WriteLine("5. Search Movie by Director or Rating");
            Console.WriteLine("6. Display All Movies (Forward)");
            Console.WriteLine("7. Display All Movies (Reverse)");
            Console.WriteLine("8. Update Movie Rating");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Director: ");
                    string director = Console.ReadLine();
                    Console.Write("Enter Year of Release: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Rating: ");
                    double rating = Convert.ToDouble(Console.ReadLine());

                    if (choice == 1) movieList.AddAtBeginning(title, director, year, rating);
                    else if (choice == 2) movieList.AddAtEnd(title, director, year, rating);
                    else
                    {
                        Console.Write("Enter Position: ");
                        int position = Convert.ToInt32(Console.ReadLine());
                        movieList.AddAtPosition(position, title, director, year, rating);
                    }
                    break;

                case 4:
                    Console.Write("Enter Movie Title to remove: ");
                    movieList.RemoveMovie(Console.ReadLine());
                    break;

                case 5:
                    Console.Write("Enter Director (or press Enter to skip): ");
                    string searchDirector = Console.ReadLine();
                    Console.Write("Enter Rating (or -1 to skip): ");
                    double searchRating = Convert.ToDouble(Console.ReadLine());
                    movieList.SearchMovie(searchDirector, searchRating);
                    break;

                case 6:
                    movieList.DisplayForward();
                    break;

                case 7:
                    movieList.DisplayReverse();
                    break;

                case 8:
                    Console.Write("Enter Movie Title to update rating: ");
                    string updateTitle = Console.ReadLine();
                    Console.Write("Enter New Rating: ");
                    double newRating = Convert.ToDouble(Console.ReadLine());
                    movieList.UpdateRating(updateTitle, newRating);
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
