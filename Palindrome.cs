using System;

class Palindrome
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Call the PalindromeString method and print the result
        bool isPalindrome = PalindromeString(input);
        Console.WriteLine("Is Palindrome? " + isPalindrome);
    }

    static bool PalindromeString(string input)
    {
        int i = 0;
        int j = input.Length - 1;

        char[] c = input.ToCharArray();

        while (i < j)
        {
            if (c[i] != c[j])
            {
                return false;  // Return false immediately if characters don't match
            }
            i++; // Move left pointer forward
            j--; // Move right pointer backward
        }
        
        return true; // If the loop completes, the string is a palindrome
    }
}
