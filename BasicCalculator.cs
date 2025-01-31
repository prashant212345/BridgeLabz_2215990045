using System;

class BasicCalculator
{
    static void Main()
    {
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice (1-4): ");
        
        int choice = int.Parse(Console.ReadLine());

        // Get numbers from the user
        double num1 = GetInput("Enter first number: ");
        double num2 = GetInput("Enter second number: ");

        double result = 0;
        bool validChoice = true;

        // Perform the selected operation
        if (choice == 1)
        {
            result = Add(num1, num2);
            DisplayResult(num1 + " + " + num2 + " = " + result);
        }
        else if (choice == 2)
        {
            result = Subtract(num1, num2);
            DisplayResult(num1 + " - " + num2 + " = " + result);
        }
        else if (choice == 3)
        {
            result = Multiply(num1, num2);
            DisplayResult(num1 + " × " + num2 + " = " + result);
        }
        else if (choice == 4)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                validChoice = false;
            }
            else
            {
                result = Divide(num1, num2);
                DisplayResult(num1 + " ÷ " + num2 + " = " + result);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
            validChoice = false;
        }
    }

    // Function to get input from the user
    static double GetInput(string message)
    {
        Console.Write(message);
        return double.Parse(Console.ReadLine());
    }

    // Function to perform addition
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Function to perform subtraction
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Function to perform multiplication
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Function to perform division
    static double Divide(double a, double b)
    {
        return a / b;
    }

    // Function to display the result
    static void DisplayResult(string result)
    {
        Console.WriteLine("Result: " + result);
    }
}

