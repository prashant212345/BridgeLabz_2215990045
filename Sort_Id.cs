using System;

public class Sort_Id
{
	static void Main()
	{
		Console.Write("ENter Total Empolyees : ");
		int n = int.Parse(Console.ReadLine());

		Console.Write("\nEnter Total Ids for the Employee : ");
		string[] inp = Console.ReadLine().Split(',');

		int[] arr = new int[n];
		for(int i = 0; i<n; i++)
		{
			arr[i] = int.Parse(inp[i]);
		}
		SortedId(arr);
	}
	public static void SortedId(int[] arr)
	{
		for (int i = 1; i < arr.Length; i++) { 
			int key = arr[i];
			int j = i-1;
			while (j >= 0 && arr[j] > key)
			{
				arr[j+1] = arr[j];
				j--;
			}
			arr[j+1] = key;
		}
		Console.Write("Sorted Ids : ");
		foreach (int i in arr) { 
			Console.Write(i + ",");
		}
    }
}
