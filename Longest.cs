using System;

class Longest
{
    // Main method: Entry point of the program
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        
        // Read the input string from the user
        string input = Console.ReadLine();
        
        // Call the longestWord method to find the longest word in the input string
        string word = longestWord(input);
        
        // Print the longest word
        Console.WriteLine("Longest Word : " + word);
    }

    // Method to find the longest word in a string
    static string longestWord(string input)
    {
        // Split the input string into words using a space delimiter
        string[] word = input.Split(" "); // Fixed delimiter from "," to " " (space)
        
        // Initialize variables to keep track of the longest word and its length
        string str = "";
        int l = 0;

        // Loop through each word in the array
        foreach (string s in word)
        {
            // Check if the current word is longer than the previous longest word
            if (s.Length > l)
            {
                l = s.Length;  // Update the length of the longest word
                str = s;       // Update the longest word
            }
        }

        // Return the longest word
        return str;
    }
}
