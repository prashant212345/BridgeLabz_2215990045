using System;

class MultiplicationTable{
    static void Main(){
        Console.Write("Enter a number between 6 and 9: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the entered number is between 6 and 9
        if (number < 6 || number > 9)
        {
            Console.WriteLine("Please enter a number between 6 and 9.");
            return; // Exit the program if the input is not in the valid range
        }

        // Declare an array to store the multiplication result for the number
        int[] multiplicationResult = new int[10];

        // Use a for loop to calculate the multiplication table for the given number
        for (int i = 1; i <= 10; i++)
        {
            multiplicationResult[i - 1] = number * i; // Store the result
        }

        // Display the multiplication table from the array in the required format
        Console.WriteLine("\nMultiplication table of "+(number)+":");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(number + " * " + (i + 1) + " = " + multiplicationResult[i]);
        }
    }
}
