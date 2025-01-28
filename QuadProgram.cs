using System;

class QuadProgram
{
    // Method to find the roots of the quadratic equation
    static void FindRoots(double a, double b, double c)
    {
        // Calculate delta (discriminant)
        double delta = Math.Pow(b, 2) - 4 * a * c;
        
        if (delta > 0)
        {
            // If delta is positive, calculate two real roots
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("The roots are real and different:");
            Console.WriteLine($"Root 1: {root1}");
            Console.WriteLine($"Root 2: {root2}");
        }
        else if (delta == 0)
        {
            // If delta is zero, calculate one real root
            double root = -b / (2 * a);
            Console.WriteLine("The root is real and same:");
            Console.WriteLine($"Root: {root}");
        }
        else
        {
            // If delta is negative, there are no real roots
            Console.WriteLine("No real roots, the discriminant is negative.");
        }
    }

    static void Main()
    {
        // Take input for coefficients a, b, and c
        Console.WriteLine("Enter the coefficients for the quadratic equation ax^2 + bx + c = 0");

        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Call the method to find the roots
        FindRoots(a, b, c);
    }
}

