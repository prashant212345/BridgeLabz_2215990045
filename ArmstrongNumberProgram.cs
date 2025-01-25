using System;

class ArmstrongNumberProgram
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a number to check if it is an Armstrong number: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            return;
        }

        // Initialize variables
        int originalNumber = number; // Store the original number
        int sum = 0; // Initialize sum to 0

        // Check Armstrong condition using while loop
        while (originalNumber != 0)
        {
            int remainder = originalNumber % 10; // Get the last digit
            sum += remainder * remainder * remainder; // Add the cube of the digit to the sum
            originalNumber /= 10; // Remove the last digit
        }

        // Check if the sum equals the original number
        if (sum == number)
        {
            Console.WriteLine(number + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(number + " is not an Armstrong number.");
        }
    }
}
