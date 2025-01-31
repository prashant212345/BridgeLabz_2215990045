using System;

class FactorialRecursion
{
    static void Main()
    {
        // Get input from the user
        int num = GetInput();

        // Calculate factorial using recursion
        long result = CalculateFactorial(num);

        // Display the result
        DisplayResult(num, result);
    }

    // Function to get input from the user
    static int GetInput()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    // Recursive function to calculate factorial
    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1; // Base case: 0! = 1 and 1! = 1

        return n * CalculateFactorial(n - 1); // Recursive case
    }

    // Function to display the result
    static void DisplayResult(int num, long factorial)
    {
        Console.WriteLine("Factorial of " + num + " is: " + factorial);
    }
}