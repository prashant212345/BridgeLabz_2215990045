using System;

class DArray
{
    static void Main()
    {
        // Take user input for the number of rows and columns
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        // Create a 2D array with the given number of rows and columns
        int[,] matrix = new int[rows, columns];

        // Taking input for the elements of the 2D array
        Console.WriteLine("Enter the elements of the 2D array:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element at ["+(i)+", "+(j)+"]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Create a 1D array to store the elements of the 2D array
        int[] array = new int[rows * columns];

        // Define an index variable to keep track of the current position in the 1D array
        int index = 0;

        // Loop through the 2D array and copy each element to the 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j]; // Copy element to the 1D array
                index++; // Increment the index
            }
        }

        // Display the elements of the 1D array
        Console.WriteLine("\nElements of the 1D array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
