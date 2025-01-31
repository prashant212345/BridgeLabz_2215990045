using System;

class FindMax{
	static void Main(){
		Console.Write("Enter any three number : ");
		int inp1 = int.Parse(Console.ReadLine());
		int inp2 = int.Parse(Console.ReadLine());
		int inp3 = int.Parse(Console.ReadLine());
		
		int maxval = Math.Max(inp1, Math.Max(inp2, inp3));
		Console.WriteLine("Maximum Num : "+maxval);
	}
}