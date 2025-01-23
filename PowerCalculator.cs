using System;

class PowerCalculator
{
    static void Main()
    {
        // Get input for the base number
        Console.Write("Enter the base number: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the base number.");
            return;
        }

        // Get input for the exponent (power)
        Console.Write("Enter the power: ");
        int power;
        if (!int.TryParse(Console.ReadLine(), out power) || power < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer for the power.");
            return;
        }

        // Initialize the result variable
        int result = 1;

        // Loop to calculate power
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply result by the base number
        }

        // Display the result
        Console.WriteLine("The result of " + number + " raised to the power of " + power + " is: " + result);
    }
}
