using System;

class DoubleOpt{
    static void Main(String[] args){
        // Prompt the user to enter values for a, b, and c
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Perform the double operations
        double result1 = a + b * c;    // Multiplication has higher precedence than addition
        double result2 = a * b + c;    // Multiplication has higher precedence than addition
        double result3 = c + a / b;    // Division has higher precedence than addition
        double result4 = a % b + c;    // Modulus has higher precedence than addition

        // Display the results using the specified format
        Console.WriteLine("The results of Double Operations are "+(result1)+", "+(result2)+", "+(result3)+", and "+(result4));
    }
}