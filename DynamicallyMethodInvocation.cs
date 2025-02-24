using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class ReflectionDemo
{
    static void Main()
    {
        // Step 1: Create an instance of MathOperations
        MathOperations mathOps = new MathOperations();
        
        // Step 2: Get Type information
        Type type = typeof(MathOperations);

        // Step 3: Ask user for method name
        Console.WriteLine("Enter method name (Add, Subtract, Multiply):");
        string methodName = Console.ReadLine();

        // Step 4: Get the MethodInfo dynamically
        MethodInfo method = type.GetMethod(methodName);
        
        if (method != null)
        {
            // Step 5: Ask user for two numbers
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Step 6: Invoke the method dynamically
            object result = method.Invoke(mathOps, new object[] { num1, num2 });

            // Step 7: Display the result
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}
