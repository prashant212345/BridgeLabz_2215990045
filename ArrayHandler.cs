using System;

class ArrayHandler
{
    static void Main()
    {
        int[] numbers = null;

        try
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            numbers = new int[size];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the index to retrieve:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value at index " + index + ": " + numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}