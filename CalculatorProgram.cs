using System;

class CalculatorProgram
{
    static void Main()
    {
        // Get input for the first number
        Console.WriteLine("Enter the first number:");
        double first = Convert.ToDouble(Console.ReadLine());

        // Get input for the second number
        Console.WriteLine("Enter the second number:");
        double second = Convert.ToDouble(Console.ReadLine());

        // Get input for the operator
        Console.WriteLine("Enter an operator (+, -, *, /):");
        string op = Console.ReadLine();

        // Perform calculation based on the operator
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;
            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;
            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine("Result: " + (first / second));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                break;
        }
    }
}
