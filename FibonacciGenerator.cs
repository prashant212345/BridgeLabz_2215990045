using System;

class FibonacciGenerator
{
    static void Main()
    {
        // Prompt the user to enter the number of terms
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        // Validate input
        if (terms <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Call the function to generate the Fibonacci sequence
            GenerateFibonacci(terms);
        }
    }

    // Function to generate and print the Fibonacci sequence
    static void GenerateFibonacci(int n)
    {
        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci Sequence:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " "); // Print the current term

            // Compute the next term in the sequence
            next = first + second;
            first = second;
            second = next;
        }

        Console.WriteLine(); // Move to a new line after printing the sequence
    }
}