using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    // Function to find and print all subarrays with zero sum
    public static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int sum = 0;

        Console.WriteLine("Subarrays with zero sum:");
        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            // If the sum is 0, subarray from 0 to i
            if (sum == 0)
            {
                Console.WriteLine($"[{0}, {i}]");
                found = true;
            }

            // If sum already exists in the map, it means zero sum subarrays exist
            if (sumMap.ContainsKey(sum))
            {
                foreach (int start in sumMap[sum])
                {
                    Console.WriteLine($"[{start + 1}, {i}]");
                    found = true;
                }
            }

            // Add the sum to the map
            if (!sumMap.ContainsKey(sum))
            {
                sumMap[sum] = new List<int>();
            }
            sumMap[sum].Add(i);
        }

        if (!found)
            Console.WriteLine("No subarrays found.");
    }

    // Function to take user input and process the array
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

        int[] arr = numbers.ToArray();
        FindZeroSumSubarrays(arr);
    }
}
