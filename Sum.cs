using System;

class Sum
{
    static void Main()
    {
        // Input: Prompt the user to enter a number
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Check if the input is a valid integer
        if (int.TryParse(input, out int number))
        {
            // Check if the number is a natural number (positive integer including 0)
            if (number >= 0)
            {
                // Calculate the sum of n natural numbers using the formula
                int sum = number * (number + 1) / 2;
                Console.WriteLine("The sum of "+(number)+" natural numbers is "+(sum));
            }
            else
            {
                // If the number is not a natural number
                Console.WriteLine("The number "+(number)+" is not a natural number");
            }
        }
        else
        {
            // If the input is not a valid integer
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
