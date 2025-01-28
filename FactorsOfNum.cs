using System;

class FactorsOfNum
{
    static void Main()
    {
        // Taking input from the user
        Console.WriteLine("Enter a number to find its factors:");
        int number = int.Parse(Console.ReadLine());

        // Find factors and store them in an array
        int[] factors = FindFactors(number);

        // Display the factors
        Console.WriteLine("Factors of " + number + ":");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        // Calculate and display the sum of the factors
        int sum = FindSum(factors);
        Console.WriteLine("Sum of factors: " + sum);

        // Calculate and display the product of the factors
        long product = FindProduct(factors);
        Console.WriteLine("Product of factors: " + product);

        // Calculate and display the sum of squares of the factors
        double sumOfSquares = FindSumOfSquares(factors);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }

    // Method to find factors of a number
    static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop to count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Initialize the array with the count
        int[] factors = new int[count];
        int index = 0;

        // Second loop to save the factors into the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // Method to find the sum of the factors
    static int FindSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors
    static long FindProduct(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the sum of squares of the factors
    static double FindSumOfSquares(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
}