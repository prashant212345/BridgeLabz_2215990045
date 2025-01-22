using System;
class NumberSwapper{
    static void Main(String[] args){
        // Prompt the user to enter the first number
        Console.Write("Enter the first number : ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        // Prompt the user to enter the second number
        Console.Write("Enter the second number : ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swap the numbers
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Display the swapped values
        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
