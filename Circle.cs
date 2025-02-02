using System;

// Circle class
public class Circle
{
    // Attribute of the Circle class
    public double radius;

    // Default constructor (initializes radius to 1.0)
    public Circle() : this(1.0) // Constructor chaining
    {
        // The default constructor uses the parameterized constructor to initialize radius to 1.0
        Console.WriteLine("Default Constructor: Radius set to 1.0");
    }

    // Parameterized constructor (initializes radius with a user-provided value)
    public Circle(double circleRadius)
    {
        radius = circleRadius;
        Console.WriteLine("Parameterized Constructor: Radius set to " + radius);
    }

    // Method to calculate and return the area of the circle
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to display the radius of the circle
    public void DisplayCircleDetails()
    {
        Console.WriteLine("Circle Radius: " + radius);
        Console.WriteLine("Circle Area: " + CalculateArea());
    }
}

class Program
{
    static void Main()
    {
        // Creating a Circle object using the default constructor (radius will be set to 1.0)
        Circle circle1 = new Circle();
        circle1.DisplayCircleDetails();

        Console.WriteLine();

        // Creating a Circle object using the parameterized constructor (radius set to 5.0)
        Circle circle2 = new Circle(5.0);
        circle2.DisplayCircleDetails();
    }
}
