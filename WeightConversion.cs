using System;

class WeightConversion{
    static void Main(string[] args){
        // Get input from the user for weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert weight from pounds to kilograms
        double weightInKilograms = weightInPounds * 2.2;

        // Display the result
        Console.WriteLine("The weight of the person in pounds is " + weightInPounds + " and in kg is " + weightInKilograms);
    }
}
