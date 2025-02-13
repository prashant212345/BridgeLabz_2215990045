using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    // Function to compute maximum in each sliding window
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0 || k == 0)
            return new int[0];

        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>(); // Stores indices of elements

        for (int i = 0; i < nums.Length; i++)
        {
            // Remove elements out of the current window
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
                deque.RemoveFirst();

            // Remove smaller elements (not useful)
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                deque.RemoveLast();

            // Add current index to deque
            deque.AddLast(i);

            // Store the maximum (only after the first k elements)
            if (i >= k - 1)
                result.Add(nums[deque.First.Value]);
        }

        return result.ToArray();
    }

    // Function to take user input and print sliding window maximum
    public static void Main()
    {
        Console.WriteLine("Enter array elements (comma-separated): ");
        string input = Console.ReadLine();
        string[] tokens = input.Split(',');

        List<int> numbers = new List<int>();
        foreach (var token in tokens)
        {
            if (int.TryParse(token.Trim(), out int num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine($"Invalid input ignored: {token}");
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No valid numbers entered.");
            return;
        }

        Console.Write("Enter window size (k): ");
        if (!int.TryParse(Console.ReadLine(), out int k) || k <= 0 || k > numbers.Count)
        {
            Console.WriteLine("Invalid window size.");
            return;
        }

        int[] nums = numbers.ToArray();
        int[] maxWindow = MaxSlidingWindow(nums, k);

        Console.WriteLine("\nSliding Window Maximum:");
        Console.WriteLine(string.Join(" ", maxWindow));
    }
}
