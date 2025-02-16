using System;

public class PeakElementSearch
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int peakIndex = FindPeakElement(arr);

        Console.WriteLine($"A peak element is found at index: {peakIndex}, value: {arr[peakIndex]}");
    }

    public static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[mid + 1])
                right = mid; // Peak is in the left half (including mid)
            else
                left = mid + 1; // Peak is in the right half
        }

        return left; // Index of a peak element
    }
}
