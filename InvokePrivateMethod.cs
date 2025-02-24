using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class ReflectionDemo
{
    static void Main()
    {
        // Step 1: Create an instance of Calculator
        Calculator calc = new Calculator();
        
        // Step 2: Get Type information
        Type type = typeof(Calculator);
        
        // Step 3: Access the private method "Multiply"
        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (method != null)
        {
            // Step 4: Invoke the private method with arguments (5, 6)
            object result = method.Invoke(calc, new object[] { 5, 6 });

            // Step 5: Display the result
            Console.WriteLine("Multiplication Result: " + result);
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}
