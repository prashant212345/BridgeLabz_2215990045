using System;

class Check
{
    static void Main()
    {
        // Input: Prompt the user to enter a number
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Check if the input is a valid integer
        if (int.TryParse(input, out int number))
        {
            // Determine whether the number is positive, negative, or zero
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else
        {
            // If the input is not a valid integer
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
