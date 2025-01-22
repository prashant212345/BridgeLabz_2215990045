using System;

class HeightConverter{
    // Main method
    static void Main(String[] args){
        // Prompt the user to enter their height in centimeters
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Conversion constants
        double cmPerInch = 2.54;
        int inchesPerFoot = 12;

        // Convert height from centimeters to inches
        double totalInches = heightCm / cmPerInch;

        // Calculate feet and remaining inches
        int feet = (int)(totalInches / inchesPerFoot);
        double inches = totalInches % inchesPerFoot;

        // Display the results
        Console.WriteLine("Your height in cm is "+(heightCm)+" while in feet is "+(feet)+" and inches is "+(inches));
    }
}
