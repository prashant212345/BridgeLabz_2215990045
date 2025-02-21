using System;

class NestedTryCatchDemo
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the index to access:");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                int value = numbers[index];

                Console.WriteLine("Enter the divisor:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                try
                {
                    int result = value / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}