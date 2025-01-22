using System;
class TemperatureConversion{
    static void Main(String[] args){
        // Prompt the user to enter the temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the formula
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Display the result
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
    }
}
