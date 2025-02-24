using System;
using System.Reflection;

// Step 1: Define a custom attribute
[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Step 2: Apply the custom attribute to a class
[Author("John Doe")]
class SampleClass
{
    public void DisplayMessage()
    {
        Console.WriteLine("This is a sample class.");
    }
}

class ReflectionDemo
{
    static void Main()
    {
        // Step 3: Get Type information of the class
        Type type = typeof(SampleClass);

        // Step 4: Retrieve the custom attribute
        object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

        if (attributes.Length > 0)
        {
            // Step 5: Extract and display the attribute value
            AuthorAttribute author = (AuthorAttribute)attributes[0];
            Console.WriteLine("Author of SampleClass: " + author.Name);
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }
}
