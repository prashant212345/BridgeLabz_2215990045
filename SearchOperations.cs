using System;

public class SearchOperations
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the list: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the list:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Finding the first missing positive integer
        int missingNumber = FindFirstMissingPositive(arr);
        Console.WriteLine("First missing positive integer: " + missingNumber);

        // Sorting the array before Binary Search
        Array.Sort(arr);
        Console.Write("Enter the target number to find index: ");
        int target = int.Parse(Console.ReadLine());

        int index = BinarySearch(arr, target);
        Console.WriteLine(index == -1 ? "Target not found." : $"Target found at index: {index}");
    }

    // Function to find the first missing positive integer using Linear Search
    public static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        bool[] present = new bool[n + 1]; // Track presence of numbers 1 to n

        // Mark numbers that are present in range [1, n]
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0 && arr[i] <= n)
            {
                present[arr[i]] = true;
            }
        }

        // Find the first missing positive integer
        for (int i = 1; i <= n; i++)
        {
            if (!present[i])
                return i;
        }

        return n + 1; // If all numbers from 1 to n are present, return n+1
    }

    // Function to perform Binary Search
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Target not found
    }
}
