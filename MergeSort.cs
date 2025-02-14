using System;

class MergeSort
{
    // Method to merge two sorted subarrays
    public static void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Create temporary arrays
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copy data to temporary arrays
        for (int i = 0; i < n1; i++)
            leftArray[i] = prices[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[mid + 1 + j];

        int iIndex = 0, jIndex = 0, kIndex = left;

        // Merge the two sorted subarrays
        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                prices[kIndex] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                prices[kIndex] = rightArray[jIndex];
                jIndex++;
            }
            kIndex++;
        }

        // Copy any remaining elements from leftArray
        while (iIndex < n1)
        {
            prices[kIndex] = leftArray[iIndex];
            iIndex++;
            kIndex++;
        }

        // Copy any remaining elements from rightArray
        while (jIndex < n2)
        {
            prices[kIndex] = rightArray[jIndex];
            jIndex++;
            kIndex++;
        }
    }

    // Recursive method to apply Merge Sort
    public static void Sort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            // Recursively sort first and second halves
            Sort(prices, left, mid);
            Sort(prices, mid + 1, right);

            // Merge the sorted halves
            Merge(prices, left, mid, right);
        }
    }

    public static void Main()
    {
        // Example book prices array
        int[] bookPrices = { 499, 150, 299, 799, 350, 599 };

        Console.WriteLine("Original Book Prices:");
        foreach (int price in bookPrices)
        {
            Console.Write(price + " ");
        }

        // Sort the book prices using Merge Sort
        Sort(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("\nSorted Book Prices:");
        foreach (int price in bookPrices)
        {
            Console.Write(price + " ");
        }
    }
}