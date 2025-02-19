using System;
using System.Collections.Generic;

public class LinkedListNode
{
    public char Data;
    public LinkedListNode Next;

    public LinkedListNode(char data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    public LinkedListNode Head;

    public void Add(char data)
    {
        if (Head == null)
        {
            Head = new LinkedListNode(data);
            return;
        }

        LinkedListNode current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = new LinkedListNode(data);
    }

    public char FindNthFromEnd(int n)
    {
        LinkedListNode fast = Head, slow = Head;

        // Move fast pointer N steps ahead
        for (int i = 0; i < n; i++)
        {
            if (fast == null)
                throw new ArgumentException("N is larger than the list size");
            fast = fast.Next;
        }

        // Move both pointers until fast reaches the end
        while (fast != null)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        return slow.Data;
    }
}

class FindNode
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        list.Add('A');
        list.Add('B');
        list.Add('C');
        list.Add('D');
        list.Add('E');

        int N = 2;
        char result = list.FindNthFromEnd(N);
        Console.WriteLine(result);
    }
}
