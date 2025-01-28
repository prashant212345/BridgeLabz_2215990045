using System;
using System.Linq;

class HarshadNumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] GetDigitsArray(int number)
    {
        return number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
    }

    // Method to find the sum of the digits of the number
    public static int SumOfDigits(int[] digits)
    {
        return digits.Sum();
    }

    // Method to find the sum of the squares of the digits of the number
    public static int SumOfSquaresOfDigits(int[] digits)
    {
        return digits.Sum(digit => (int)Math.Pow(digit, 2));
    }

    // Method to check if a number is a Harshad number
    public static bool IsHarshadNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int sumOfDigits = SumOfDigits(digits);
        return number % sumOfDigits == 0;
    }

    // Method to find the frequency of each digit in the number
    public static int[,] FindDigitFrequencies(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[,] frequencyArray = new int[10, 2];

        // Initialize the first column with digits 0-9
        for (int i = 0; i < 10; i++)
        {
            frequencyArray[i, 0] = i; // Digit
            frequencyArray[i, 1] = 0; // Initial frequency
        }

        // Calculate frequencies
        foreach (int digit in digits)
        {
            frequencyArray[digit, 1]++;
        }

        return frequencyArray;
    }

    static void Main()
    {
        int number = 1729; // Example number, can be replaced with user input
        Console.WriteLine("Number: " + number);

        // Count digits
        int digitCount = CountDigits(number);
        Console.WriteLine("Number of Digits: " + digitCount);

        // Get digits array
        int[] digits = GetDigitsArray(number);
        Console.Write("Digits Array: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]);
            if (i < digits.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        // Sum of digits
        int sumOfDigits = SumOfDigits(digits);
        Console.WriteLine("Sum of Digits: " + sumOfDigits);

        // Sum of squares of digits
        int sumOfSquares = SumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of Squares of Digits: " + sumOfSquares);

        // Check if the number is a Harshad number
        bool isHarshad = IsHarshadNumber(number);
        Console.WriteLine("Is Harshad Number: " + isHarshad);

        // Find the frequency of each digit
        int[,] frequencies = FindDigitFrequencies(number);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequencies[i, 1] > 0)
            {
                Console.WriteLine("Digit: " + frequencies[i, 0] + ", Frequency: " + frequencies[i, 1]);
            }
        }
    }
}
