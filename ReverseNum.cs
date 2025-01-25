using System;

class ReverseNum
{
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find the count of digits in the number
        int count = 0;
        int tempNumber = number;
        while (tempNumber != 0)
        {
            tempNumber /= 10;
            count++;
        }

        // Create an array to store the digits
        int[] digits = new int[count];

        // Store the digits in the array
        tempNumber = number;
        for (int i = 0; i < count; i++)
        {
            digits[i] = tempNumber % 10; // Get the last digit
            tempNumber /= 10; // Remove the last digit
        }

        // Display the digits array in reverse order
        Console.Write("Reversed number: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine(); // Move to the next line after printing the reversed number
    }
}
