using System;

class PalindromeChecker
{
    static void Main()
    {
        // Read user input
        string input = GetInput();

        // Check if the string is a palindrome
        bool isPalindrome = CheckPalindrome(input);

        // Display the result
        DisplayResult(input, isPalindrome);
    }

    // Function to get input from the user
    static string GetInput()
    {
        Console.Write("Enter a word or phrase: ");
        return Console.ReadLine();
    }

    // Function to check if a given string is a palindrome
    static bool CheckPalindrome(string str)
    {
        // Convert string to lowercase and remove spaces for uniform comparison
        str = str.ToLower().Replace(" ", "");

        int left = 0, right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false; // If mismatch found, it's not a palindrome
            }
            left++;
            right--;
        }

        return true; // If loop completes, it's a palindrome
    }

    // Function to display the result
    static void DisplayResult(string input, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine(input + " is a palindrome.");
        }
        else
        {
            Console.WriteLine(input + " is not a palindrome.");
        }
    }
}
