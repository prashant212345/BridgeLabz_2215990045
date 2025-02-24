using System;
using System.Reflection;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

// Step 2: Apply the attribute to methods
class Project
{
    [Todo("Implement user authentication", "Alice", "HIGH")]
    public void AuthenticateUser()
    {
        Console.WriteLine("Authenticating user...");
    }

    [Todo("Optimize database queries", "Bob", "MEDIUM")]
    public void OptimizeDatabase()
    {
        Console.WriteLine("Optimizing database...");
    }

    [Todo("Add unit tests for API", "Charlie")]
    public void AddUnitTests()
    {
        Console.WriteLine("Adding unit tests...");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Retrieve and print pending tasks using reflection
        Type type = typeof(Project);
        MethodInfo[] methods = type.GetMethods();

        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);
            foreach (TodoAttribute attr in attributes)
            {
                Console.WriteLine("Task: " + attr.Task);
                Console.WriteLine("Assigned To: " + attr.AssignedTo);
                Console.WriteLine("Priority: " + attr.Priority);
                Console.WriteLine("Method: " + method.Name);
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
