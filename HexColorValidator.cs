using System;
using System.Text.RegularExpressions;

public class HexColorValidator
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ValidateHexColor("#FFA500"));
        Console.WriteLine(ValidateHexColor("#ff4500"));
        Console.WriteLine(ValidateHexColor("#123"));
    }

    public static string ValidateHexColor(string color)
    {
        if (Regex.IsMatch(color, "^#[0-9A-Fa-f]{6}$"))
        {
            return "Valid";
        }
        else
        {
            return "Invalid";
        }
    }
}