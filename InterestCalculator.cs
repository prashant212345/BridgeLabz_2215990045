using System;

class InterestCalculator
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Invalid input: Amount and rate must be positive");
        }
        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the principal amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the interest rate:");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of years:");
            int years = Convert.ToInt32(Console.ReadLine());

            double interest = CalculateInterest(amount, rate, years);

            Console.WriteLine("Calculated Interest: " + interest);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}