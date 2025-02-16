using System;
using System.Text;

public class ConcatString
{
	static void Main() {
		Console.Write("Enter the no of words : ");
		int n = int.Parse(Console.ReadLine());

		string[] inp = new string[n];
		Console.WriteLine("Enter the words one by one : ");
		for(int i=0; i<n; i++)
		{
			inp[i] = Console.ReadLine();
		}

		string s = concatenate(inp);
		Console.WriteLine(s);
	}
	public static string concatenate(string[] input) {
		StringBuilder sb = new StringBuilder();

		foreach (string s in input) { 
			sb.Append(s);
		}
		return sb.ToString();
	}
}
