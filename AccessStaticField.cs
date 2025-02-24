using System;
using System.Reflection;

class Configuration
{
    // Step 1: Define a private static field
    private static string API_KEY = "INITIAL_KEY";

    // Step 2: Method to display the API_KEY
    public static void ShowAPIKey()
    {
        Console.WriteLine("Current API_KEY: " + API_KEY);
    }
}

class ReflectionDemo
{
    static void Main()
    {
        // Step 3: Get Type information of Configuration class
        Type type = typeof(Configuration);

        // Step 4: Get the private static field using Reflection
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (field != null)
        {
            // Step 5: Modify the value of API_KEY
            field.SetValue(null, "NEW_SECRET_KEY");

            // Step 6: Display the updated value
            Configuration.ShowAPIKey();
        }
        else
        {
            Console.WriteLine("Field not found.");
        }
    }
}
