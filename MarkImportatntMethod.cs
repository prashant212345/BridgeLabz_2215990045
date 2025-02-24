using System;
using System.Reflection;

// Step 1: Define the custom attribute with an optional Level parameter
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

// Step 2: Apply the attribute to methods
class Operations
{
    [ImportantMethod] // Default level is "HIGH"
    public void CriticalOperation()
    {
        Console.WriteLine("Executing critical operation...");
    }

    [ImportantMethod("MEDIUM")]
    public void SecondaryOperation()
    {
        Console.WriteLine("Executing secondary operation...");
    }

    public void NormalOperation()
    {
        Console.WriteLine("Executing normal operation...");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Retrieve and print annotated methods using reflection
        Type type = typeof(Operations);
        MethodInfo[] methods = type.GetMethods();

        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(ImportantMethodAttribute), false);
            foreach (ImportantMethodAttribute attr in attributes)
            {
                Console.WriteLine("Method: " + method.Name + " | Importance Level: " + attr.Level);
            }
        }
    }
}
