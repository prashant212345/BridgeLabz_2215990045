using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
    // Generic method to map dictionary values to object properties
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        // Step 1: Create an instance of the specified type
        T obj = new T();
        Type type = typeof(T);

        // Step 2: Iterate through the dictionary and set matching properties
        foreach (var property in properties)
        {
            PropertyInfo propInfo = type.GetProperty(property.Key, BindingFlags.Public | BindingFlags.Instance);
            if (propInfo != null && propInfo.CanWrite)
            {
                // Convert the value to the correct type
                object convertedValue = Convert.ChangeType(property.Value, propInfo.PropertyType);
                propInfo.SetValue(obj, convertedValue);
            }
        }

        return obj;
    }
}

// Sample class to test the mapper
class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Is Active: " + IsActive);
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Create a dictionary with property values
        Dictionary<string, object> userProperties = new Dictionary<string, object>
        {
            { "Name", "Alice" },
            { "Age", 25 },
            { "IsActive", true }
        };

        // Step 4: Convert dictionary to a User object
        User user = ObjectMapper.ToObject<User>(userProperties);

        // Step 5: Display mapped object details
        user.DisplayInfo();
    }
}
