using System;

class DistanceConverter{
    // Main method 
    static void Main(String[] args){
        // Prompt the user to enter a distance in kilometers
        Console.Write("Enter the distance in kilometers: ");

        // Read the input from the user and convert it to a double
        double km = Convert.ToDouble(Console.ReadLine());

        // Conversion factor from kilometers to miles
        double kmToMiles = 1.6;

        // Calculate the distance in miles
        double miles = km / kmToMiles;

        // Display the result
        Console.WriteLine("The total miles is " + miles + " miles for the given " + km + " km");
    }
}
