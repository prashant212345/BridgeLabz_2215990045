using System;
using System.Text;

public class RemoveDuplicates
{
	static void Main() {
		Console.Write("Enter the string : ");
		string inp = Console.ReadLine();

		string ans = removeDuplicate(inp);
        Console.WriteLine(ans);
	}
	public static string removeDuplicate(string inp) { 
		StringBuilder sb = new StringBuilder();
		string s = "";

		foreach (char c in inp) {
			if (s.IndexOf(c) == -1) { 
				sb.Append(c);
				s += c;
			}
		}
		return sb.ToString();
	}
}
