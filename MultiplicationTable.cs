using System;

class MultiplicationTable
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number to generate the multiplication table: ");
        
        // Read the user input and parse it to an integer
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Loop to print the multiplication table from 6 to 9
            for (int i = 6; i <= 9; i++)
            {
                int result = number * i;
                Console.WriteLine(number + " * " + i + " = " + result);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
