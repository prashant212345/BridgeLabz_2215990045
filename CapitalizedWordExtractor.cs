using System;
using System.Text.RegularExpressions;

public class CapitalizedWordExtractor
{
    public static void Main(string[] args)
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        ExtractCapitalizedWords(text);
    }

    public static void ExtractCapitalizedWords(string text)
    {
        Regex capitalizedWordRegex = new Regex(@"\b[A-Z][a-z]*\b");
        MatchCollection matches = capitalizedWordRegex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}