using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    // Function to find the longest consecutive sequence length
    public static int FindLongestConsecutiveSequence(int[] arr)
    {
        HashSet<int> numSet = new HashSet<int>(arr);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            // Start only if num is the beginning of a sequence
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
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
        int result = FindLongestConsecutiveSequence(arr);
        Console.WriteLine($"\nLength of longest consecutive sequence: {result}");
    }
}
