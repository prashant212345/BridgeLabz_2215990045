using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    // Function to check for a pair with the given sum
    public static bool FindPairWithSum(int[] arr, int target)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            // If complement exists in the set, pair is found
            if (seenNumbers.Contains(complement))
            {
                Console.WriteLine($"Pair found: ({complement}, {arr[i]})");
                return true;
            }

            // Add the current number to the set
            seenNumbers.Add(arr[i]);
        }

        Console.WriteLine("No pair found.");
        return false;
    }

    // Function to take user input and find the pair
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
        FindPairWithSum(arr, target);
    }
}
using System;

public class Class1
{
	public Class1()
	{
	}
}
