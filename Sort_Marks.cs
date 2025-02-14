using System;

public class Sort_Marks
{
    static void Main()
    {
        Console.Write("Enter total Students : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("\nEnter the Marks for Students : ");
        string[] inp = Console.ReadLine().Split(',');

        int[] arr = new int[n];
        for(int i=0; i<n; i++)
        {
            arr[i] = int.Parse(inp[i]);
        }

        SortedMarks(arr);
    }
    public static void SortedMarks(int[] arr)
    {
        bool swapped;
        for (int i = 0; i < arr.Length - 1; i++) { 
            swapped = false;
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) {
                break;
            }
        }
        Console.Write("Sorted Marks of the Students : ");
        foreach (int i in arr)
        {
            Console.Write(i + ",");
        }
    }
}
