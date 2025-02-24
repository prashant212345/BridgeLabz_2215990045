using System;
using System.Reflection;

// Step 1: Define a custom attribute
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
class TaskInfoAttribute : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

// Step 2: Apply the custom attribute to a method
class TaskManager
{
    [TaskInfo(1, "John Doe")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Use reflection to retrieve attribute details
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("CompleteTask");

        if (method != null)
        {
            object[] attributes = method.GetCustomAttributes(typeof(TaskInfoAttribute), false);
            foreach (TaskInfoAttribute attr in attributes)
            {
                Console.WriteLine("Task Priority: " + attr.Priority);
                Console.WriteLine("Assigned To: " + attr.AssignedTo);
            }
        }
    }
}
