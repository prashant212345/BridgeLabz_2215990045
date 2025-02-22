using System;
using System.Text.RegularExpressions;

public class LanguageExtractor
{
    public static void Main(string[] args)
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        ExtractLanguages(text);
    }

    public static void ExtractLanguages(string text)
    {
        Regex languageRegex = new Regex(@"\b(Java|Python|JavaScript|Go)\b");
        MatchCollection matches = languageRegex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}