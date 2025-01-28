using System;

public static class UnitConvertor
{
    // Convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the UnitConvertor class
        Console.WriteLine("Enter kilometers to convert to miles:");
        double km = double.Parse(Console.ReadLine());
        Console.WriteLine(km + " km is " + UnitConvertor.ConvertKmToMiles(km) + " miles.");

        Console.WriteLine("Enter miles to convert to kilometers:");
        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine(miles + " miles is " + UnitConvertor.ConvertMilesToKm(miles) + " kilometers.");

        Console.WriteLine("Enter meters to convert to feet:");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters is " + UnitConvertor.ConvertMetersToFeet(meters) + " feet.");

        Console.WriteLine("Enter feet to convert to meters:");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet is " + UnitConvertor.ConvertFeetToMeters(feet) + " meters.");
    }
}
