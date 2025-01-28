using System;

public static class TempConvertor
{
    // Convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the UnitConvertor class
        Console.WriteLine("Enter Fahrenheit to convert to Celsius:");
        double fahrenheit = double.Parse(Console.ReadLine());
        Console.WriteLine(fahrenheit + "°F is " + UnitConvertor.ConvertFahrenheitToCelsius(fahrenheit) + "°C.");

        Console.WriteLine("Enter Celsius to convert to Fahrenheit:");
        double celsius = double.Parse(Console.ReadLine());
        Console.WriteLine(celsius + "°C is " + UnitConvertor.ConvertCelsiusToFahrenheit(celsius) + "°F.");

        Console.WriteLine("Enter pounds to convert to kilograms:");
        double pounds = double.Parse(Console.ReadLine());
        Console.WriteLine(pounds + " pounds is " + UnitConvertor.ConvertPoundsToKilograms(pounds) + " kilograms.");

        Console.WriteLine("Enter kilograms to convert to pounds:");
        double kilograms = double.Parse(Console.ReadLine());
        Console.WriteLine(kilograms + " kilograms is " + UnitConvertor.ConvertKilogramsToPounds(kilograms) + " pounds.");

        Console.WriteLine("Enter gallons to convert to liters:");
        double gallons = double.Parse(Console.ReadLine());
        Console.WriteLine(gallons + " gallons is " + UnitConvertor.ConvertGallonsToLiters(gallons) + " liters.");

        Console.WriteLine("Enter liters to convert to gallons:");
        double liters = double.Parse(Console.ReadLine());
        Console.WriteLine(liters + " liters is " + UnitConvertor.ConvertLitersToGallons(liters) + " gallons.");
    }
}
