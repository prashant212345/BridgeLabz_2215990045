using System;
using System.Reflection;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

// Step 2: Apply the attribute to a class field and validate in the constructor
class User
{
    [MaxLength(10)] // Restricts Username to a maximum length of 10 characters
    public string Username { get; }

    public User(string username)
    {
        // Step 3: Validate length using reflection
        PropertyInfo property = typeof(User).GetProperty("Username");
        MaxLengthAttribute maxLengthAttr = (MaxLengthAttribute)Attribute.GetCustomAttribute(property, typeof(MaxLengthAttribute));

        if (maxLengthAttr != null && username.Length > maxLengthAttr.Length)
        {
            throw new ArgumentException($"Username exceeds the maximum allowed length of {maxLengthAttr.Length} characters.");
        }

        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User validUser = new User("JohnDoe");
            Console.WriteLine($"Valid Username: {validUser.Username}");

            User invalidUser = new User("VeryLongUsername123"); // Should throw exception
            Console.WriteLine($"Invalid Username: {invalidUser.Username}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
