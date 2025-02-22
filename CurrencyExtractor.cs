using System;
using System.Text.RegularExpressions;

public class CurrencyExtractor
{
    public static void Main(string[] args)
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        ExtractCurrencyValues(text);
    }

    public static void ExtractCurrencyValues(string text)
    {
        Regex currencyRegex = new Regex(@"\$\s?\d+(\.\d{1,2})?");
        MatchCollection matches = currencyRegex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}