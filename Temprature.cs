//Write a program that takes the temperature in Celsius as input and converts it to Fahrenheit using the formula: 
//Fahrenheit = (Celsius * 9/5) + 32.


using System;

class Temprature
{
    static void Main()
    {
        
        double celsius, fahrenheit;

       
        Console.Write("Enter the temperature in Celsius: ");
        celsius = double.Parse(Console.ReadLine()); 

        
        fahrenheit = (celsius * 9 / 5) + 32;

        
        Console.WriteLine("{0} C is equivalent to {1} F", celsius, fahrenheit);
    }
}