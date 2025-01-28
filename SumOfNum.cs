using System;

class SumOfNum
{
    static void Main()
    {
        // Take user input
        Console.WriteLine("Enter a natural number:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid input! Please enter a positive integer.");
            return;
        }

        // Calculate the sum using recursion
        int sumRecursive = SumRecursive(n);

        // Calculate the sum using the formula
        int sumFormula = SumUsingFormula(n);

        // Display the results
        Console.WriteLine("Sum of first " + n + " natural numbers using recursion: " + sumRecursive);
        Console.WriteLine("Sum of first " + n + " natural numbers using formula: " + sumFormula);

        // Compare the results
        if (sumRecursive == sumFormula)
        {
            Console.WriteLine("The results match! Both computations are correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. There might be an error in computation.");
        }
    }

    // Method to calculate the sum of n natural numbers using recursion
    static int SumRecursive(int n)
    {
        if (n == 1) // Base case: sum of the first natural number is itself
        {
            return 1;
        }
        return n + SumRecursive(n - 1); // Recursive case
    }

    // Method to calculate the sum of n natural numbers using the formula
    static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
