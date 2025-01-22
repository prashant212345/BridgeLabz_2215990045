using System;

class SquareSideCalculator{
    // Main method
    static void Main(String[] args){
        // Prompt the user to enter the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side of the square
        double side = perimeter / 4;

        // Display the result
        Console.WriteLine("The length of the side is "+(side)+" whose perimeter is "+(perimeter));
    }
}
