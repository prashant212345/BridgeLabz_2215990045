using System;

class Duplicates
{
    // Main method: The entry point of the program
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        
        // Read the input string from the user
        string input = Console.ReadLine();
        
        // Call the removeDuplicates method to remove duplicate characters from the input string
        string word = removeDuplicates(input);
        
        // Print the result after duplicates are removed
        Console.WriteLine(word);
    }

    // Method to remove duplicate characters from the input string
    static string removeDuplicates(string input)
    {
        // Initialize an empty string to store unique characters
        string unique = "";

        // Flag variable to check if a character is already in the 'unique' string
        bool flag = true;

        // Loop through each character in the input string
        foreach (char a in input)
        {
            // Loop through each character in the 'unique' string to check for duplicates
            foreach (char b in unique)
            {
                // If the character 'a' already exists in the 'unique' string, set flag to false
                if (a == b)
                {
                    flag = false;
                    break;  // Exit the inner loop since we found a duplicate
                }
                flag = true;  // If no duplicate found, set flag to true
            }

            // If the flag is still true, add the character 'a' to the 'unique' string
            if (flag)
            {
                unique += a;
            }
        }

        // Return the 'unique' string with duplicates removed
        return unique;
    }
}
