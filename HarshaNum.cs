using System;

class HarshaNum
{
    static void Main()
    {
        // Input an integer number
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Store the original number for later use
        int originalNumber = number;

        // Initialize sum variable
        int sum = 0;

        // Loop to calculate the sum of digits
        while (number != 0)
        {
            int digit = number % 10; // Extract the last digit
            sum += digit;           // Add the digit to the sum
            number = number / 10;   // Remove the last digit
        }

        // Check if the original number is divisible by the sum of its digits
        if (originalNumber % sum == 0)
        {
            Console.WriteLine(originalNumber + " is a Harshad Number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not a Harshad Number.");
        }
    }
}
