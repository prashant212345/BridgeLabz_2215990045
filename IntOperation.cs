using System;

class IntOperation{
    static void Main(String[] args){
        // Prompt the user to enter values for a, b, and c
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Perform the integer operations
        int result1 = a + b * c;    // Multiplication has higher precedence than addition
        int result2 = a * b + c;    // Multiplication has higher precedence than addition
        int result3 = c + a / b;    // Division has higher precedence than addition
        int result4 = a % b + c;    // Modulus has higher precedence than addition

        // Display the results
        Console.WriteLine("The results of Int Operations are "+(result1)+", "+(result2)+", "+(result3)+", and "+(result4));
    }
}
