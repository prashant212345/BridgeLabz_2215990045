//Write a program that takes three numbers as input from the user and prints their average. 

using System;

class Average
{
    static void Main()
    {
        double num1, num2, num3, average;
        Console.Write("Enter the first number: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        num3 = double.Parse(Console.ReadLine());
        average = (num1 + num2 + num3) / 3;
        Console.WriteLine(average);
    }
}