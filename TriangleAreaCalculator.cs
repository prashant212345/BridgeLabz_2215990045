using System;

class TriangleAreaCalculator{
    // Main method
    static void Main(String[] args){
        // Prompt the user to enter the base of the triangle in centimeters
        Console.Write("Enter the base of the triangle in centimeters: ");
        double baseCm = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the height of the triangle in centimeters
        Console.Write("Enter the height of the triangle in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle in square centimeters
        double areaCm2 = 0.5 * baseCm * heightCm;

        // Conversion factor: 1 cm² = 0.155 square inches
        double areaInches2 = areaCm2 * 0.155;

        // Display the results
        Console.WriteLine("The area of the triangle is "+(areaCm2)+" square centimeters and "+(areaInches2)+" square inches.");
    }
}
