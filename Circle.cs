using System;

public class Circle
{
    // Fields
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("Circle Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

// Main Class to Test
public class Program
{
    public static void Main(string[] args)
    {
        Circle circle1 = new Circle(5);
        circle1.DisplayDetails();
    }
}
