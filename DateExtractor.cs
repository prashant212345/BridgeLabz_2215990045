using System;
using System.Text.RegularExpressions;

public class DateExtractor
{
    public static void Main(string[] args)
    {
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
        ExtractDates(text);
    }

    public static void ExtractDates(string text)
    {
        Regex dateRegex = new Regex(@"\b\d{2}/\d{2}/\d{4}\b");
        MatchCollection matches = dateRegex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}