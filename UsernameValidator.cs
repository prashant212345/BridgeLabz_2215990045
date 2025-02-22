using System;
using System.Text.RegularExpressions;

public class UsernameValidator
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ValidateUsername("user_123"));
        Console.WriteLine(ValidateUsername("123user"));  
        Console.WriteLine(ValidateUsername("us"));       
    }

    public static string ValidateUsername(string username)
    {
        if (username.Length < 5 || username.Length > 15)
        {
            return "Invalid (too short or too long)";
        }

        if (Regex.IsMatch(username, "^[a-zA-Z][a-zA-Z0-9_]*$"))
        {
            return "Valid";
        }
        else
        {
            return "Invalid";
        }
    }
}