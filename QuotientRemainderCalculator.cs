using System;

class QuotientRemainderCalculator{
    static void Main(String[] args){
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Display the results
        Console.WriteLine("The Quotient is "+(quotient)+" and Remainder is "+(remainder)+" of two numbers "+(number1)+" and "+(number2));
    }
}
