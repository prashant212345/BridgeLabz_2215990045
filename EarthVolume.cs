using System;

class EarthVolume{
    // Main method
    static void Main(String[] args){
        // initialize the radius of Earth
        double radiusKm = 6378;

        // Conversion factor from cubic kilometers to cubic miles
        double kmToMilesConversion = 0.621371;

        // Calculate the volume of Earth in cubic kilometers using the formula (4/3) * pi * r^3
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        // Convert the volume from cubic kilometers to cubic miles
        double volumeMiles3 = volumeKm3 * Math.Pow(kmToMilesConversion, 3);

        // Display the results
        Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm3 + " cubic miles is " + volumeMiles3);
    }
}
