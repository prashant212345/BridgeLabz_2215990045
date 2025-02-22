using System;
using System.Text.RegularExpressions;

public class LicensePlateValidator
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ValidateLicensePlate("AB1234"));
        Console.WriteLine(ValidateLicensePlate("A12345"));
    }

    public static string ValidateLicensePlate(string plate)
    {
        if (Regex.IsMatch(plate, "^[A-Z]{2}[0-9]{4}$"))
        {
            return "Valid";
        }
        else
        {
            return "Invalid";
        }
    }
}