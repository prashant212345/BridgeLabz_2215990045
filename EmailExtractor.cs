using System;
using System.Text.RegularExpressions;

public class EmailExtractor
{
    public static void Main(string[] args)
    {
        string text = "Contact us at support@example.com and info@company.org";
        ExtractEmails(text);
    }

    public static void ExtractEmails(string text)
    {
        Regex emailRegex = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
        MatchCollection matches = emailRegex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}