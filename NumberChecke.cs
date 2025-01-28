using System;
using System.Linq;

class NumberChecke
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

    // Method to reverse the digits array
    public static int[] ReverseDigitsArray(int[] digits)
    {
        return digits.Reverse().ToArray();
    }

    // Method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }
        return true;
    }

    // Method to check if a number is a palindrome
    public static bool IsPalindrome(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[] reversedDigits = ReverseDigitsArray(digits);
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        // Get digits array
        int[] digits = GetDigitsArray(number);

        // Duck numbers must have at least one '0' digit but not as the leading digit
        return digits.Skip(1).Contains(0);
    }

    static void Main()
    {
        int number = 12021; // Example number, can be replaced with user input
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

        // Reverse the digits array
        int[] reversedDigits = ReverseDigitsArray(digits);
        Console.Write("Reversed Digits Array: ");
        for (int i = 0; i < reversedDigits.Length; i++)
        {
            Console.Write(reversedDigits[i]);
            if (i < reversedDigits.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        // Check if the number is a palindrome
        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine("Is Palindrome: " + isPalindrome);

        // Check if the number is a duck number
        bool isDuckNumber = IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuckNumber);
    }
}
