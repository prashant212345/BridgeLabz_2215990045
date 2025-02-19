using System;
using System.Collections;

public class RemoveDuplicates
{
	static void Main()
	{
		ArrayList list = new ArrayList() { 3,1,2,2,3,5};

		ArrayList ans = removeDuplicate(list);
        foreach (int item in ans)
        {
			Console.Write(item + " ");
        }
    }
	public static ArrayList removeDuplicate(ArrayList list)
	{
		ArrayList rem = new ArrayList();
		foreach (int i in list) { 
			if(!rem.Contains(i)) 
				rem.Add(i);
		}
		return rem;
	}
}
