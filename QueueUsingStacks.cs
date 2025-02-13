using System;
using System.Collections.Generic;

public class QueueUsingStacks
{
    private Stack<int> stack1;
    private Stack<int> stack2;

    public QueueUsingStacks()
    {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }

    // Enqueue operation (Push into stack1)
    public void Enqueue(int item)
    {
        stack1.Push(item);
        Console.WriteLine($"{item} enqueued.");
    }

    // Dequeue operation (Pop from stack2)
    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return -1;
        }

        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        int dequeuedItem = stack2.Pop();
        Console.WriteLine($"{dequeuedItem} dequeued.");
        return dequeuedItem;
    }

    // Peek front element
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return -1;
        }

        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Peek();
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }

    public static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter value to enqueue: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        queue.Enqueue(value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Enter an integer.");
                    }
                    break;
                case 2:
                    queue.Dequeue();
                    break;
                case 3:
                    int front = queue.Peek();
                    if (front != -1)
                        Console.WriteLine($"Front element: {front}");
                    break;
                case 4:
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter 1-4.");
                    break;
            }
        }
    }
}
