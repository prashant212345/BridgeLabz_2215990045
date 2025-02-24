using System;
using System.Text;
using System.Reflection;

class JsonConverter
{
    // Method to convert an object to a JSON-like string
    public static string ToJson(object obj)
    {
        if (obj == null) return "{}";

        Type type = obj.GetType();
        StringBuilder json = new StringBuilder();
        json.Append("{\n");

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            object value = field.GetValue(obj);

            json.Append("  \"" + field.Name + "\": ");

            // Format value based on type
            if (value is string)
                json.Append("\"" + value + "\"");
            else if (value is bool)
                json.Append(value.ToString().ToLower());
            else
                json.Append(value);

            if (i < fields.Length - 1)
                json.Append(",");

            json.Append("\n");
        }

        json.Append("}");
        return json.ToString();
    }
}

// Sample class with public fields
class Person
{
    public string Name;
    public int Age;
    public bool IsActive;

    public Person(string name, int age, bool isActive)
    {
        Name = name;
        Age = age;
        IsActive = isActive;
    }
}

class Program
{
    static void Main()
    {
        // Create an object of Person
        Person person = new Person("Alice", 25, true);

        // Convert object to JSON-like string
        string jsonOutput = JsonConverter.ToJson(person);

        // Print JSON representation
        Console.WriteLine(jsonOutput);
    }
}
