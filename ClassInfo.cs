using System;
using System.Reflection;

class ReflectionDemo
{
    static void Main()
    {
        Console.Write("Enter the class name (e.g., System.String, ReflectionDemo): ");
        string className = Console.ReadLine();

        try
        {
            // Step 1: Get Type Information
            Type type = Type.GetType(className);
            if (type == null)
            {
                Console.WriteLine("Class not found.");
                return;
            }

            Console.WriteLine($"\nClass: {type.FullName}");

            // Step 2: Display Constructors
            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor);
            }

            // Step 3: Display Fields
            Console.WriteLine("\nFields:");
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var field in fields)
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");
            }

            // Step 4: Display Methods
            Console.WriteLine("\nMethods:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var method in methods)
            {
                Console.WriteLine($"{method.ReturnType} {method.Name}()");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
