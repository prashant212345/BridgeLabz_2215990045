using System;

class DivByFive
{
    static void Main()
    {
        // Input: Prompt the user to enter a number
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int number))
        {
            // Check divisibility by 5
            if (number % 5 == 0)
            {
                Console.WriteLine("Is the number " + number + " divisible by 5? Yes");
            }
            else
            {
                Console.WriteLine("Is the number " + number + " divisible by 5? No");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
