using System;

class AthleteRun{
    static void Main(string[] args){
        // Prompt user for input for the three sides of the triangle
        Console.Write("Enter the length of side 1 of the triangle (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 of the triangle (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 of the triangle (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Convert 5 km to meters (5000 meters)
        double totalDistance = 5000;

        // Calculate the number of rounds required to cover the total distance
        double rounds = totalDistance / perimeter;

        // Output the result
        Console.WriteLine("The total number of rounds the athlete will run is "+Math.Ceiling(rounds)+" to complete 5 km is ");
    }
}
