using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Convert Fahrenheit to Celsius");
        Console.WriteLine("2. Convert Celsius to Fahrenheit");
        Console.Write("Enter your choice (1 or 2): ");
        
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // Convert Fahrenheit to Celsius
            double fahrenheit = GetInput("Enter temperature in Fahrenheit: ");
            double celsius = FahrenheitToCelsius(fahrenheit);
            DisplayResult(fahrenheit + "°F is equal to " + celsius + "°C");
        }
        else if (choice == 2)
        {
            // Convert Celsius to Fahrenheit
            double celsius = GetInput("Enter temperature in Celsius: ");
            double fahrenheit = CelsiusToFahrenheit(celsius);
            DisplayResult(celsius + "°C is equal to " + fahrenheit + "°F");
        }
        else
        {
            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
        }
    }

    // Function to get user input
    static double GetInput(string message)
    {
        Console.Write(message);
        return double.Parse(Console.ReadLine());
    }

    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }
    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }
    static void DisplayResult(string result)
    {
        Console.WriteLine(result);
    }
}

