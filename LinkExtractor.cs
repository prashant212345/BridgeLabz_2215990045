using System;
using System.Text.RegularExpressions;

public class LinkExtractor
{
    public static void Main(string[] args)
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        ExtractLinks(text);
    }

    public static void ExtractLinks(string text)
    {
        Regex linkRegex = new Regex(@"https?://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
        MatchCollection matches = linkRegex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}