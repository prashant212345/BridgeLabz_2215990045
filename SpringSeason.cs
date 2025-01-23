using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        // Check if there are exactly two command line arguments (month and day)
        if (args.Length == 2)
        {
            // Parse the arguments as integers
            if (int.TryParse(args[0], out int month) && int.TryParse(args[1], out int day))
            {
                // Check if the month and day are within the Spring season
                if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
                {
                    Console.WriteLine("It's a Spring Season");
                }
                else
                {
                    Console.WriteLine("Not a Spring Season");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid month and day.");
            }
        }
        else
        {
            Console.WriteLine("Please provide both month and day as arguments.");
        }
    }
}
