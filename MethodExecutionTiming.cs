using System;
using System.Diagnostics;
using System.Reflection;

public class SampleClass
{
    public void FastMethod()
    {
        for (int i = 0; i < 1000; i++) { } // Quick loop
    }

    public void SlowMethod()
    {
        System.Threading.Thread.Sleep(500); // Simulate a slow operation
    }
}

public class MethodTimer
{
    public static void MeasureExecutionTime(object instance, string methodName)
    {
        Type type = instance.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found: " + methodName);
            return;
        }

        Stopwatch stopwatch = Stopwatch.StartNew();

        method.Invoke(instance, null); // Invoke method dynamically

        stopwatch.Stop();
        Console.WriteLine("Execution Time of " + methodName + ": " + stopwatch.ElapsedMilliseconds + " ms");
    }
}

class Program
{
    static void Main()
    {
        SampleClass obj = new SampleClass();

        // Measure execution time of methods
        MethodTimer.MeasureExecutionTime(obj, "FastMethod");
        MethodTimer.MeasureExecutionTime(obj, "SlowMethod");
    }
}
