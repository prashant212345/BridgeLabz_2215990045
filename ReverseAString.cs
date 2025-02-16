using System;
using System.Text;

public class ReverseAString
{
    static void Main()
    {
        Console.Write("Enter the string : ");
        string str = Console.ReadLine();

        StringBuilder sb = new StringBuilder(str);
        Console.WriteLine(rverse(sb));
    }
    public static string rverse(StringBuilder sb)
    {
        StringBuilder s = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            s.Append(sb[i]);
        }
        return s.ToString();
    }
}