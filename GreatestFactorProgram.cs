using System;

class GreatestFactorProgram
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter an integer: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        // Initialize the greatest factor variable
        int greatestFactor = 1;

        // Loop from number - 1 to 1 to find the greatest factor
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break; // Exit the loop as we found the greatest factor
            }
        }

        // Display the greatest factor
        Console.WriteLine("The greatest factor of " + number + " besides itself is: " + greatestFactor);
    }
}
