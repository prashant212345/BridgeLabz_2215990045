using System;
using System.Text;
using System.Diagnostics;

public class StringBuilderPerformance
{
	static void Main()
	{
		int iterations = 100000;  // number of concatenations

		// measure performance of string
		Stopwatch sw = Stopwatch.StartNew();
		string s = "";
		for (int i = 0; i < iterations; i++) { 
			s += "a";
		}
		sw.Stop();
		Console.WriteLine("Time taken using string : "+sw.ElapsedMilliseconds +"ms");

        // measure performance of string
		sw.Restart();
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < iterations; i++) { 
			sb.Append("a");
		}
		sw.Stop();
		Console.Write("Time taken using StringBuilder : "+sw.ElapsedMilliseconds +"ms");
    }
}
