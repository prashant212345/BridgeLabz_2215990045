using System;

class DistanceConvert{
    // Main method
    static void Main(String[] args){
        // Prompt the user to enter the distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Conversion constants
        double feetPerYard = 3;
        double yardsPerMile = 1760;

        // Convert feet to yards
        double distanceInYards = distanceInFeet / feetPerYard;

        // Convert yards to miles
        double distanceInMiles = distanceInYards / yardsPerMile;

        // Display the results
        Console.WriteLine("The distance in yards is "+(distanceInYards)+" and in miles is "+(distanceInMiles)+" for the given "+(distanceInFeet)+" feet.");
    }
}
