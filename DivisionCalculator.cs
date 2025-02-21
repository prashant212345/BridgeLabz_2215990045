using System;

class DivisionCalculator
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the first number:");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / denominator;

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}