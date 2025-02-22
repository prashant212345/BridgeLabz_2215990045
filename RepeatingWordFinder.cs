using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class RepeatingWordFinder
{
    public static void Main(string[] args)
    {
        string input = "This is is a repeated repeated word test.";
        FindRepeatingWords(input);
    }

    public static void FindRepeatingWords(string text)
    {
        Regex wordRegex = new Regex(@"\b\w+\b");
        MatchCollection matches = wordRegex.Matches(text);

        HashSet<string> wordSet = new HashSet<string>();
        HashSet<string> repeatedWords = new HashSet<string>();

        foreach (Match match in matches)
        {
            string word = match.Value.ToLower();
            if (wordSet.Contains(word))
            {
                repeatedWords.Add(word);
            }
            else
            {
                wordSet.Add(word);
            }
        }

        foreach (var word in repeatedWords)
        {
            Console.WriteLine(word);
        }
    }
}