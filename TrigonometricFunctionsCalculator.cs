using System;

class TrigonometricFunctionsCalculator
{
    static void Main()
    {
        // Taking user input for the angle in degrees
        Console.Write("Enter the angle in degrees: ");
        double angleInDegrees = Convert.ToDouble(Console.ReadLine());

        // Calculating trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angleInDegrees);

        // Displaying the results
        Console.WriteLine("Sine: "+(results[0]));
        Console.WriteLine("Cosine: "+(results[1]));
        Console.WriteLine("Tangent: "+(results[2]));
    }

    // Method to calculate various trigonometric functions (sine, cosine, and tangent)
    public static double[] CalculateTrigonometricFunctions(double angleInDegrees)
    {
        // Convert the angle to radians
        double angleInRadians = angleInDegrees * Math.PI / 180;

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);

        // Return the results as an array
        return new double[] { sine, cosine, tangent };
    }
}
