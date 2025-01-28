using System;
using System.Linq;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] GetDigitsArray(int number)
    {
        string numStr = number.ToString();
        return numStr.Select(digit => int.Parse(digit.ToString())).ToArray();
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        return digits.Skip(1).Contains(0); // Duck number must have at least one zero, but not at the start
    }

    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int numDigits = digits.Length;
        int sum = digits.Sum(digit => (int)Math.Pow(digit, numDigits));
        return sum == number;
    }

    // Method to find the largest and second largest elements in the digits array
    public static (int largest, int secondLargest) FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue, secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }

        return (largest, secondLargest);
    }

    // Method to find the smallest and second smallest elements in the digits array
    public static (int smallest, int secondSmallest) FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue, secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }

        return (smallest, secondSmallest);
    }

    static void Main()
    {
        int number = 153; // Example number, can be replaced with user input
        Console.WriteLine($"Number: {number}");

        // Count digits
        int digitCount = CountDigits(number);
        Console.WriteLine($"Number of Digits: {digitCount}");

        // Get digits array
        int[] digits = GetDigitsArray(number);
        Console.WriteLine($"Digits Array: {string.Join(", ", digits)}");

        // Check if the number is a Duck number
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine($"Is Duck Number: {isDuck}");

        // Check if the number is an Armstrong number
        bool isArmstrong = IsArmstrongNumber(number);
        Console.WriteLine($"Is Armstrong Number: {isArmstrong}");

        // Find the largest and second largest digits
        var (largest, secondLargest) = FindLargestAndSecondLargest(digits);
        Console.WriteLine($"Largest Digit: {largest}, Second Largest Digit: {secondLargest}");

        // Find the smallest and second smallest digits
        var (smallest, secondSmallest) = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine($"Smallest Digit: {smallest}, Second Smallest Digit: {secondSmallest}");
    }
}
