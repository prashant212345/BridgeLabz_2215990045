using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        Name = "Default Name";
        Age = 18;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Student Age: " + Age);
    }
}

class ReflectionDemo
{
    static void Main()
    {
        // Step 1: Get Type information
        Type type = typeof(Student);

        // Step 2: Create an instance dynamically (without 'new' keyword)
        object obj = Activator.CreateInstance(type);

        // Step 3: Display information using the method in the Student class
        MethodInfo method = type.GetMethod("DisplayInfo");
        if (method != null)
        {
            method.Invoke(obj, null);
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}
