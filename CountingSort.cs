using System;

class CountingSort
{
    // Method to perform Counting Sort on student ages
    public static void Sort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1; // Range of ages (10 to 18)
        int[] count = new int[range]; // Count array
        int[] output = new int[ages.Length]; // Output array

        // Step 1: Count occurrences of each age
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        // Step 2: Compute cumulative count
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        // Step 3: Place elements in correct positions in output array
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        // Copy sorted values back to the original array
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }

    public static void Main()
    {
        // Example student ages array
        int[] studentAges = { 12, 15, 14, 10, 18, 16, 14, 12, 17, 11 };

        Console.WriteLine("Original Student Ages:");
        foreach (int age in studentAges)
        {
            Console.Write(age + " ");
        }

        // Sorting the student ages using Counting Sort
        Sort(studentAges, 10, 18);

        Console.WriteLine("\nSorted Student Ages:");
        foreach (int age in studentAges)
        {
            Console.Write(age + " ");
        }
    }
}