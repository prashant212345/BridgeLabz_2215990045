using System;
using System.Collections;
using System.Collections.Generic;

public class ReverseList
{
	static void Main()
	{
		ArrayList list = new ArrayList() { 1,2,3,4,5};

		ArrayList reverseList = ReverseArrayList(list);
		Console.Write("Reverse ArrayList : ");
		foreach (int i in reverseList)
		{
			Console.Write(i + " ");
		}

		LinkedList<int> ll = new LinkedList<int>();
		ll.AddFirst(1);
		ll.AddLast(2);
		ll.AddLast(3);
		ll.AddLast(4);
		ll.AddLast(5);

		LinkedList<int> reversell = ReverseLinkedList(ll);
		Console.Write("\nReverse LinkedList : ");
        foreach (int i in reversell)
        {
            Console.Write(i + " ");
        }
    }
	public static ArrayList ReverseArrayList(ArrayList list)
	{
		int l = 0;
		int r = list.Count - 1;
		while (l < r) { 
			object temp = list[l];
			list[l] = list[r];
			list[r] = temp;
			l++;
			r--;
		}
		return list;
	}
	public static LinkedList<int> ReverseLinkedList(LinkedList<int> ll)
	{
		LinkedList<int> reverse = new LinkedList<int> ();
        foreach (var item in ll)
        {
			reverse.AddFirst(item);
        }
        return reverse;	
	}
}
