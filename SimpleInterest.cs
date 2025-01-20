//Write a program to calculate simple interest using the formula: Simple Interest = (Principal * Rate * Time) / 100. 

using System;

class SimpleInterest
{
    static void Main()
    {
        double principal, rate, time, simpleInterest;
        Console.Write("Enter the principal amount: ");
        principal = double.Parse(Console.ReadLine());
        Console.Write("Enter the rate of interest: ");
        rate = double.Parse(Console.ReadLine());
        Console.Write("Enter the time period in years: ");
        time = double.Parse(Console.ReadLine());
        simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine(simpleInterest);
    }
}