using System;
class TemperatureConversio{
    static void Main(String[] args){
        // Prompt the user to enter the temperature in Fahrenheit
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert Fahrenheit to Celsius using the formula
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Display the result
        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsiusResult + " Celsius");
    }
}
