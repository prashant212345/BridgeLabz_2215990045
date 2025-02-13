using System;
using System.Collections.Generic;

class TwoSumSolution
{
    // Function to find two indices that sum to the target
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            // If complement exists, return the indices
            if (numIndexMap.ContainsKey(complement))
            {
                return new int[] { numIndexMap[complement], i };
            }

            // Store the index of the current number
            numIndexMap[nums[i]] = i;
        }

        return new int[] { -1, -1 }; // No valid pair found
    }

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

        Console.Write("Enter target sum: ");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Invalid target sum.");
            return;
        }

        int[] arr = numbers.ToArray();
        int[] result = TwoSum(arr, target);

        if (result[0] != -1)
        {
            Console.WriteLine($"Indices found: ({result[0]}, {result[1]})");
        }
        else
        {
            Console.WriteLine("No valid pair found.");
        }
    }
}
