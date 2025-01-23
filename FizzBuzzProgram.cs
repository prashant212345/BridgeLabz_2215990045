using System;

class FizzBuzzProgram
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number;

        if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        Console.WriteLine("FizzBuzz results:");
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
