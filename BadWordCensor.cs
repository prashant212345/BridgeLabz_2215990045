using System;
using System.Text.RegularExpressions;

public class BadWordCensor
{
    public static void Main(string[] args)
    {
        string input = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" };
        string output = CensorBadWords(input, badWords);
        Console.WriteLine(output);
    }

    public static string CensorBadWords(string input, string[] badWords)
    {
        foreach (string badWord in badWords)
        {
            input = Regex.Replace(input, @"\b" + Regex.Escape(badWord) + @"\b", "****", RegexOptions.IgnoreCase);
        }
        return input;
    }
}