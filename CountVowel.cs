using System;

class CountVowel
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        // Convert the string to lowercase to handle case insensitivity
        input = input.ToLower();

        // Variables to store vowel and consonant counts
        int vowelCount = 0, consonantCount = 0;

        // Loop through each character in the input string
        foreach (char c in input)
        {
            // Check if the character is a letter
            if (char.IsLetter(c))
            {
                // Check if the character is a vowel
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }

        // Display the results without using string interpolation
        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Number of consonants: " + consonantCount);
    }
}
