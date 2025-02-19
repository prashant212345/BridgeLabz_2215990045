using System;
using System.Collections;
using System.Collections.Generic;

public class RotateList
{
	static void Main()
	{
        ArrayList list = new ArrayList() { 10,20,30,40,50};
		int n = 2;

		ArrayList ans = rotationList(list, n);
		foreach(int i in ans){
			Console.WriteLine(i + " ");
		}
	}
	public static ArrayList rotationList(ArrayList list, int n)
	{
		int size = list.Count;
		n = n % size;
		ArrayList rotated = new ArrayList();

		for (int i = n; i < size; i++) { 
			rotated.Add(list[i]);
		}
		for (int i = 0; i < n; i++) {
			rotated.Add(list[i]);
		}
		return rotated;
	}
}

