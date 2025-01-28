using System;
using System.Collections.Generic;

class NumberChec
{
    // Method to find factors of a number
    public static int[] GetFactors(int number)
    {
        List<int> factors = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors.Add(i);
            }
        }
        return factors.ToArray();
    }

    // Method to find the greatest factor of a number
    public static int GetGreatestFactor(int[] factors)
    {
        int greatest = int.MinValue;
        foreach (int factor in factors)
        {
            if (factor > greatest)
            {
                greatest = factor;
            }
        }
        return greatest;
    }

    // Method to find the sum of the factors
    public static int GetSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors
    public static int GetProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of the factors
    public static double GetProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int[] factors = GetFactors(number);
        int sumOfProperDivisors = GetSumOfFactors(factors) - number; // Exclude the number itself
        return sumOfProperDivisors == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int[] factors = GetFactors(number);
        int sumOfProperDivisors = GetSumOfFactors(factors) - number; // Exclude the number itself
        return sumOfProperDivisors > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int[] factors = GetFactors(number);
        int sumOfProperDivisors = GetSumOfFactors(factors) - number; // Exclude the number itself
        return sumOfProperDivisors < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int originalNumber = number;
        int sumOfFactorials = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sumOfFactorials += Factorial(digit);
            number /= 10;
        }

        return sumOfFactorials == originalNumber;
    }

    // Helper method to calculate factorial
    public static int Factorial(int number)
    {
        if (number == 0 || number == 1)
            return 1;

        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
{
    int number = 28; // Example number, can be replaced with user input
    Console.WriteLine("Number: " + number);

    // Find and display factors
    int[] factors = GetFactors(number);
    Console.Write("Factors: ");
    for (int i = 0; i < factors.Length; i++)
    {
        if (i != 0) Console.Write(", ");
        Console.Write(factors[i]);
    }
    Console.WriteLine();

    // Greatest factor
    int greatestFactor = GetGreatestFactor(factors);
    Console.WriteLine("Greatest Factor: " + greatestFactor);

    // Sum of factors
    int sumOfFactors = GetSumOfFactors(factors);
    Console.WriteLine("Sum of Factors: " + sumOfFactors);

    // Product of factors
    int productOfFactors = GetProductOfFactors(factors);
    Console.WriteLine("Product of Factors: " + productOfFactors);

    // Product of cube of factors
    double productOfCube = GetProductOfCubeOfFactors(factors);
    Console.WriteLine("Product of Cube of Factors: " + productOfCube);

    // Check if perfect number
    Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number));

    // Check if abundant number
    Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(number));

    // Check if deficient number
    Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(number));

    // Check if strong number
    Console.WriteLine("Is Strong Number: " + IsStrongNumber(number));
}

}
