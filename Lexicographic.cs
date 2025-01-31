using System;

class Lexicographic
{
    static void Main()
    {
        // Taking input from the user
        Console.Write("Enter First String: ");
        string inp1 = Console.ReadLine();

        Console.Write("Enter Second String: ");
        string inp2 = Console.ReadLine();

        // Determine which string comes first lexicographically
        string ans = StrLexico(inp1, inp2);

        // Display result
        if (inp1 == ans)
        {
            Console.WriteLine(inp1 + " comes before " + inp2 + " in Lexicographic Order");
        }
        else if (inp2 == ans)
        {
            Console.WriteLine(inp2 + " comes before " + inp1 + " in Lexicographic Order");
        }
        else
        {
            Console.WriteLine("Both strings are equal.");
        }
    }

    // Method to compare two strings lexicographically
    static string StrLexico(string inp1, string inp2)
    {
        int len1 = inp1.Length;
        int len2 = inp2.Length;
        int minLength = Math.Min(len1, len2); // Find the minimum length

        // Compare character by character
        for (int i = 0; i < minLength; i++)
        {
            if (inp1[i] < inp2[i]) // inp1 comes first
            {
                return inp1;
            }
            else if (inp1[i] > inp2[i]) // inp2 comes first
            {
                return inp2;
            }
        }

        // If all characters match, the shorter string comes first
        return len1 < len2 ? inp1 : inp2;
    }
}
