using System;

class Most_Frequent
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int[] freq = new int[256];

        for (int i = 0; i < input.Length; i++)
        {
            freq[input[i]]++;
        }

        char maxChar = ' ';
        int maxFreq = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (freq[input[i]] > maxFreq)
            {
                maxFreq = freq[input[i]];
                maxChar = input[i];
            }
        }

        Console.WriteLine(string.Format("Most Frequent Character: {0}", maxChar));
    }
}