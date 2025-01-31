using System;

class Remove_Char
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadKey().KeyChar;
        Console.WriteLine();

        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != charToRemove)
            {
                result += input[i];
            }
        }

        Console.WriteLine(string.Format("Modified String: {0}", result));
    }
}

