using System;

class Anagram
{
    public static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine().ToLower();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine().ToLower();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] freq1 = new int[256];
        int[] freq2 = new int[256];

        for (int i = 0; i < str1.Length; i++)
        {
            freq1[str1[i]]++;
            freq2[str2[i]]++;
        }

        bool isAnagram = true;
        for (int i = 0; i < 256; i++)
        {
            if (freq1[i] != freq2[i])
            {
                isAnagram = false;
                break;
            }
        }

        Console.WriteLine(string.Format("Are Anagrams: {0}", isAnagram ? "Yes" : "No"));
    }
}

