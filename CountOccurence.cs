using System;

class CountOccurence
{
    static void Main()
    {
        // Take user input
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();

        Console.WriteLine("Enter the substring to search for:");
        string substring = Console.ReadLine();

        // Call the method to count substring occurrences
        int count = CountSubstringOccurrences(mainString, substring);

        // Display the result
        Console.WriteLine($"The substring '{substring}' occurs {count} times in the main string.");
    }
    static int CountSubstringOccurrences(string mainString, string substring)
    {
        int count = 0;
        int mainLength = mainString.Length;
        int subLength = substring.Length;

        // Loop through the main string and check for the substring at each position
        for (int i = 0; i <= mainLength - subLength; i++)
        {
            // Compare characters manually
            bool isMatch = true;
            for (int j = 0; j < subLength; j++)
            {
                if (mainString[i + j] != substring[j])
                {
                    isMatch = false;
                    break;
                }
            }

            // If the substring is found, increment the count
            if (isMatch)
            {
                count++;
            }
        }

        return count;
    }
}
