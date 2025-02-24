using System;
using System.Diagnostics;
using System.Reflection;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class LogExecutionTimeAttribute : Attribute {}

// Step 2: Create a helper class to invoke methods with execution time logging
class MethodExecutor
{
    public static void ExecuteWithLogging(object obj, string methodName)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        if (method != null && method.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) != null)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(obj, null);
            stopwatch.Stop();
            Console.WriteLine($"Execution Time for {methodName}: {stopwatch.ElapsedMilliseconds} ms\n");
        }
        else
        {
            Console.WriteLine($"Method {methodName} does not have LogExecutionTime attribute.\n");
        }
    }
}

// Step 3: Apply the attribute to methods
class SampleOperations
{
    [LogExecutionTime]
    public void QuickTask()
    {
        Console.WriteLine("Executing QuickTask...");
        System.Threading.Thread.Sleep(500); // Simulate work
    }

    [LogExecutionTime]
    public void SlowTask()
    {
        Console.WriteLine("Executing SlowTask...");
        System.Threading.Thread.Sleep(1500); // Simulate work
    }
}

class Program
{
    static void Main()
    {
        SampleOperations operations = new SampleOperations();
        
        // Step 4: Execute methods and log execution time
        MethodExecutor.ExecuteWithLogging(operations, "QuickTask");
        MethodExecutor.ExecuteWithLogging(operations, "SlowTask");
    }
}
