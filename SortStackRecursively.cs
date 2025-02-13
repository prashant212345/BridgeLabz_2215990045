using System;
using System.Collections.Generic;

class SortStackRecursively
{
    // Function to sort the stack using recursion
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            // Pop the top element
            int temp = stack.Pop();

            // Recursively sort the remaining stack
            SortStack(stack);

            // Insert the popped element at the correct position
            InsertSorted(stack, temp);
        }
    }

    // Helper function to insert an element in a sorted way
    private static void InsertSorted(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
            return;
        }

        // Remove the top element
        int temp = stack.Pop();

        // Recursively insert in the sorted stack
        InsertSorted(stack, element);

        // Push the removed element back
        stack.Push(temp);
    }

    // Function to take user input and sort the stack
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        Console.WriteLine("Enter numbers to push into the stack (comma-separated): ");
        string input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            string[] numbers = input.Split(',');

            foreach (string num in numbers)
            {
                if (int.TryParse(num.Trim(), out int val))
                {
                    stack.Push(val);
                }
                else
                {
                    Console.WriteLine($"Invalid input skipped: {num}");
                }
            }
        }

        Console.WriteLine("\nOriginal Stack:");
        PrintStack(stack);

        // Sort the stack
        SortStack(stack);

        Console.WriteLine("\nSorted Stack:");
        PrintStack(stack);
    }

    // Function to print the stack
    private static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
