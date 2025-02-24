using System;
using System.Reflection;

class Person
{
    private int age;

    public Person(int age)
    {
        this.age = age;
    }

    public void DisplayAge()
    {
        Console.WriteLine($"Age: {age}");
    }
}

class ReflectionDemo
{
    static void Main()
    {
        // Step 1: Create an instance of Person
        Person person = new Person(25);
        
        // Step 2: Get Type information
        Type type = typeof(Person);
        
        // Step 3: Access the private field "age"
        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if (field != null)
        {
            // Step 4: Retrieve the private field value
            int currentAge = (int)field.GetValue(person);
            Console.WriteLine($"Original Age: {currentAge}");

            // Step 5: Modify the private field value
            field.SetValue(person, 30);
            Console.WriteLine("Modified Age: " + field.GetValue(person));
        }
        else
        {
            Console.WriteLine("Field not found.");
        }

        // Verify by calling the method
        person.DisplayAge();
    }
}
