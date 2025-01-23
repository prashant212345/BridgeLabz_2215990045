using System;

class LeapYearProgram
{
    static void Main()
    {
        Console.Write("Enter a year (>= 1582): ");
        int year;
        if (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or later. The Gregorian calendar does not apply before this.");
        }
        else
        {
            // Using multiple if-else statements
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a Leap Year.");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a Leap Year.");
                    }
                }
                else
                {
                    Console.WriteLine(year + " is a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }

            // Using a single if statement with multiple logical operators
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }
        }
    }
}
