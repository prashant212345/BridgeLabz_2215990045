using System;

class Table
{
    static void Main()
    {
        
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Declare an array to store the multiplication table results
        int[] multiplicationTable = new int[10];

        // Loop from 1 to 10 to store the multiplication results in the array
        for (int i = 1; i <= 10; i++)
        {
            multiplicationTable[i - 1] = number * i;  // Store the result
        }

        // Display the multiplication table from the array
        for (int i = 0; i < 10; i++)
        {
            // Display in the format: number * i = result
            Console.WriteLine(number + " * " + (i + 1) + " = " + multiplicationTable[i]);
        }
    }
}
