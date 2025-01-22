using System;

class BasicCalculator{
    // Main method
    static void Main(String[] args){
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2; // Handle division by zero

        // Display the results
        Console.WriteLine("The addition, subtraction, multiplication, and division value of 2 numbers "+(number1)+" and "+(number2)+" is "+(addition)+", "+(subtraction)+", "+(multiplication)+", and "+(division));
    }
}
