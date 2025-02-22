using System;

public class StringModifier
{
    public static void Main(string[] args)
    {
        string input = "This  is   an    example  with  multiple   spaces.";
        string output = ReplaceMultipleSpaces(input);
        Console.WriteLine(output);
    }

    public static string ReplaceMultipleSpaces(string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ");
    }
}