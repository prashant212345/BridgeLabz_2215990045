using System;

class OddEvenNumbers
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a natural number: ");
        
        // Read the user input and parse it to an integer
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Check if the number is a natural number (positive integer)
            if (number > 0)
            {
                // Iterate from 1 to the entered number using a for loop
                for (int i = 1; i <= number; i++)
                {
                    // Check if the number is even or odd
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " is an even number.");
                    }
                    else
                    {
                        Console.WriteLine(i + " is an odd number.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive natural number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
