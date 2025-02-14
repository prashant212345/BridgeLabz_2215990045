using System;

class HeapSort
{
    // Method to sort an array using Heap Sort
    public static void Sort(int[] salaries)
    {
        int n = salaries.Length;

        // Build a max heap
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }

        // Extract elements from the heap one by one
        for (int i = n - 1; i > 0; i--)
        {
            // Swap the root (largest element) with the last element
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;

            // Heapify the reduced heap
            Heapify(salaries, i, 0);
        }
    }

    // Method to heapify a subtree rooted at index i
    private static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;   // Assume root is the largest
        int left = 2 * i + 1;  // Left child
        int right = 2 * i + 2; // Right child

        // Check if left child is larger than root
        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        // Check if right child is larger than largest so far
        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        // If the largest element is not the root, swap and heapify
        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            // Recursively heapify the affected subtree
            Heapify(arr, n, largest);
        }
    }

    public static void Main()
    {
        // Example salary demands array
        int[] salaryDemands = { 55000, 72000, 48000, 60000, 90000, 50000 };

        Console.WriteLine("Original Salary Demands:");
        foreach (int salary in salaryDemands)
        {
            Console.Write(salary + " ");
        }

        // Sort the salaries using Heap Sort
        Sort(salaryDemands);

        Console.WriteLine("\nSorted Salary Demands:");
        foreach (int salary in salaryDemands)
        {
            Console.Write(salary + " ");
        }
    }
}