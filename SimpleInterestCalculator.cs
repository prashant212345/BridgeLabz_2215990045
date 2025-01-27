using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        // Taking user input for Principal, Rate, and Time
        Console.Write("Enter Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculating Simple Interest
        double simpleInterest = CalculateSimpleInterest(principal, rate, time);

        // Displaying the output
        Console.WriteLine("The Simple Interest is " + simpleInterest + 
                          " for Principal " + principal + 
                          ", Rate of Interest " + rate + 
                          " and Time " + time + ".");
    }

    // Method to calculate Simple Interest
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}
