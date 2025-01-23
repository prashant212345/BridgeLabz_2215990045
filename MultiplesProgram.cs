using System;

class MultiplesProgram
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a positive integer to find its multiples below 100: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        Console.WriteLine("The multiples of " + number + " below 100 are:");

        // Loop from 100 to 1 (backward)
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0) // Check if i is a multiple of the number
            {
                Console.WriteLine(i);
            }
        }
    }
}
