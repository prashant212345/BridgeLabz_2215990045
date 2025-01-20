// Write a program that takes two numbers as input from the user and prints their sum.

using System;

class Addition
{
    static void Main()
    {
        
        int num1, num2, sum;

        
        Console.Write("Enter the first number: ");
        num1 = int.parse(Console.ReadLine()); 

        
        Console.Write("Enter the second number: ");
        num2 = int.parse(Console.ReadLine()); 

        
        sum = num1 + num2;

        
        Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);
    }
}