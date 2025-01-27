using System;

class AthleteRun
{
    static void Main()
    {
        // Taking user input for the three sides of the triangular park
        Console.Write("Enter the length of the first side of the triangular park (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second side of the triangular park (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the third side of the triangular park (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        // Calculating the perimeter of the triangular park
        double perimeter = CalculatePerimeter(side1, side2, side3);

        // Calculating the number of rounds needed to complete 5 km
        double distanceToRun = 5000; // 5 km in meters
        int rounds = CalculateRounds(distanceToRun, perimeter);

        // Displaying the result
        Console.WriteLine("The athlete needs to complete " + rounds + " rounds to cover 5 km.");
    }

    // Method to calculate the perimeter of the triangular park
    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    // Method to calculate the number of rounds needed
    static int CalculateRounds(double totalDistance, double perimeter)
    {
        return (int)Math.Ceiling(totalDistance / perimeter);
    }
}
