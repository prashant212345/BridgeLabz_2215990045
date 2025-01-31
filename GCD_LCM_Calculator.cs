using System;

class GCD_LCM_Calculator
{
    static void Main()
    {
        // Get input from the user
        int num1 = GetInput("Enter the first number: ");
        int num2 = GetInput("Enter the second number: ");

        // Calculate GCD using Euclidean algorithm
        int gcd = CalculateGCD(num1, num2);

        // Calculate LCM using the formula: LCM(a, b) = (a * b) / GCD(a, b)
        int lcm = CalculateLCM(num1, num2, gcd);

        // Display results
        DisplayResult(num1, num2, gcd, lcm);
    }

    // Function to get input from the user
    static int GetInput(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    // Function to calculate GCD using Euclidean algorithm
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a; // GCD is stored in 'a'
    }

    // Function to calculate LCM using the formula: (a * b) / GCD
    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a / gcd) * b; // Avoid overflow by dividing first
    }

    // Function to display results
    static void DisplayResult(int num1, int num2, int gcd, int lcm)
    {
        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }
}

