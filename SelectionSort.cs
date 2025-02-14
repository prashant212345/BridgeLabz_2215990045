using System;

class SelectionSort
{
    // Method to perform Selection Sort
    public static void Sort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i; // Assume the first element of the unsorted part is the minimum

            // Find the index of the minimum element in the remaining array
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first unsorted element
            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }
    }

    public static void Main()
    {
        // Example exam scores array
        int[] examScores = { 85, 92, 78, 88, 76, 95 };

        Console.WriteLine("Original Exam Scores:");
        foreach (int score in examScores)
        {
            Console.Write(score + " ");
        }

        // Sort the exam scores using Selection Sort
        Sort(examScores);

        Console.WriteLine("\nSorted Exam Scores:");
        foreach (int score in examScores)
        {
            Console.Write(score + " ");
        }
    }
}