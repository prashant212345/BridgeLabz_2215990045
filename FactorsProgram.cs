using System;

class FactorsProgram
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a positive integer to find its factors: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        Console.WriteLine("The factors of " + number + " are:");

        // Loop to find factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i); // Print the factor
            }
        }
    }
}
