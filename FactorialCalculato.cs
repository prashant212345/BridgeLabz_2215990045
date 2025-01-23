using System;

class FactorialCalculato
{
    static void Main()
    {
        // Prompt the user for input
        Console.Write("Enter a positive integer: ");
        
        // Read the user input and parse it to an integer
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Check if the number is a positive integer
            if (number >= 0)
            {
                // Initialize the factorial result
                long factorial = 1;

                // Use a for loop to compute the factorial
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                // Print the result
                Console.WriteLine("The factorial of " + number + " is: " + factorial);
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
