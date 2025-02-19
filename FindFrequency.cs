using System;
using System.Collections.Generic;

public class FindFrequency
{
	static void Main()
	{
		string[] str = { "apple", "banana", "apple", "orange" };

		Dictionary<string, int> ans = countFreq(str);
        foreach (var item in ans)
		{
			Console.WriteLine(item.Key+": " + item.Value);            
        }
    }
	public static Dictionary<string, int> countFreq(string[] str)
	{
        Dictionary<string, int> dict = new Dictionary<string, int>();
		foreach (string str2 in str) {
			if (!dict.ContainsKey(str2))
			{
				dict.Add(str2, 1);
			}
			else {
				dict[str2]++;
			}
		}
		return dict;
    }
}
