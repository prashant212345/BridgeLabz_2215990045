using System;

class LeapYear
{
    static void Main()
    {
        // Take user input
        Console.WriteLine("Enter a year (1582 or later):");
        if (!int.TryParse(Console.ReadLine(), out int year) || year < 1582)
        {
            Console.WriteLine("Invalid input! Please enter a year 1582 or later.");
            return;
        }

        // Check if the year is a leap year
        bool isLeapYear = CheckLeapYear(year);

        // Display the result
        if (isLeapYear)
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }

    // Method to check if a year is a leap year
    static bool CheckLeapYear(int year)
    {
        // A year is a leap year if it is divisible by 4
        // but not divisible by 100, unless it is also divisible by 400
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }
}
