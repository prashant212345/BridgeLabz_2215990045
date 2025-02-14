using System;

class QuickSort
{
    // Method to partition the array
    public static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high]; // Choosing the last element as the pivot
        int i = low - 1; // Pointer for the smaller element

        for (int j = low; j < high; j++)
        {
            if (prices[j] <= pivot) // If current element is smaller than pivot
            {
                i++;
                // Swap prices[i] and prices[j]
                int temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }

        // Swap pivot element with element at i+1
        int tempPivot = prices[i + 1];
        prices[i + 1] = prices[high];
        prices[high] = tempPivot;

        return i + 1; // Return the partition index
    }

    // Recursive method to apply Quick Sort
    public static void Sort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(prices, low, high);

            // Recursively sort elements before and after partition
            Sort(prices, low, partitionIndex - 1);
            Sort(prices, partitionIndex + 1, high);
        }
    }

    public static void Main()
    {
        // Example product prices array
        int[] productPrices = { 799, 150, 350, 499, 299, 599 };

        Console.WriteLine("Original Product Prices:");
        foreach (int price in productPrices)
        {
            Console.Write(price + " ");
        }

        // Sort the product prices using Quick Sort
        Sort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("\nSorted Product Prices:");
        foreach (int price in productPrices)
        {
            Console.Write(price + " ");
        }
    }
}