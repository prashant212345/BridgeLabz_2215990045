//Write a program that takes two numbers as input: a base and an exponent, and prints the result of base raised to the exponent (without using loops or conditionals). 

using System;

class Exponent
{
    static void Main()
    {
        double baseNum, exponent, result;
        Console.Write("Enter the base number: ");
        baseNum = double.Parse(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        exponent = double.Parse(Console.ReadLine());
        result = Math.Pow(baseNum, exponent);
        Console.WriteLine(result);
    }
}