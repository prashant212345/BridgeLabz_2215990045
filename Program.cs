//Write a program that takes the distance in kilometers as input from the user and converts it into miles using the formula: 
//Miles = Kilometers * 0.621371.

using System;

class Program
{
    static void Main()
    {
        double kilometers, miles;
        Console.Write("Enter the distance in kilometers: ");
        kilometers = double.Parse(Console.ReadLine());
        miles = kilometers * 0.621371;
        Console.WriteLine(miles);
    }
}