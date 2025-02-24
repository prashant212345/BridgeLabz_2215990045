using System;
using System.Reflection;

// Step 1: Define the repeatable attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

// Step 2: Apply the attribute multiple times on a method
class Software
{
    [BugReport("Fix null reference exception in edge case.")]
    [BugReport("Optimize performance for large datasets.")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Retrieve and print all bug reports using reflection
        Type type = typeof(Software);
        MethodInfo method = type.GetMethod("ProcessData");

        if (method != null)
        {
            object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);
            foreach (BugReportAttribute attr in attributes)
            {
                Console.WriteLine("Bug Report: " + attr.Description);
            }
        }
    }
}
