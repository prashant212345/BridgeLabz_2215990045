using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Queue<int> reversedQueue = ReverseQueue(queue);

        Console.WriteLine("Reversed Queue: " + string.Join(", ", reversedQueue));
    }

    public static Queue<int> ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        // Step 1: Move all elements from queue to stack
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        // Step 2: Move all elements back from stack to queue
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }
}
