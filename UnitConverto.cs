using System;

public static class UnitConverto
{
    // Convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // Convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // Convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    // Convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    // Convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the UnitConvertor class
        Console.WriteLine("Enter yards to convert to feet:");
        double yards = double.Parse(Console.ReadLine());
        Console.WriteLine(yards + " yards is " + UnitConvertor.ConvertYardsToFeet(yards) + " feet.");

        Console.WriteLine("Enter feet to convert to yards:");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet is " + UnitConvertor.ConvertFeetToYards(feet) + " yards.");

        Console.WriteLine("Enter meters to convert to inches:");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters is " + UnitConvertor.ConvertMetersToInches(meters) + " inches.");

        Console.WriteLine("Enter inches to convert to meters:");
        double inches = double.Parse(Console.ReadLine());
        Console.WriteLine(inches + " inches is " + UnitConvertor.ConvertInchesToMeters(inches) + " meters.");

        Console.WriteLine("Enter inches to convert to centimeters:");
        inches = double.Parse(Console.ReadLine());
        Console.WriteLine(inches + " inches is " + UnitConvertor.ConvertInchesToCentimeters(inches) + " centimeters.");
    }
}
