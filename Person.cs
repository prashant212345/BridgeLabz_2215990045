using System;

// Person class
public class Person
{
    // Attributes of the Person class
    public string name;
    public int age;

    // Default constructor (initializes name and age with default values)
    public Person()
    {
        name = "Unknown";
        age = 0;
    }

    // Parameterized constructor (initializes name and age with user-provided values)
    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
    }

    // Copy constructor (copies another person's attributes)
    public Person(Person anotherPerson)
    {
        name = anotherPerson.name;
        age = anotherPerson.age;
        Console.WriteLine("Copy Constructor: Cloned person with name: " + name + " and age: " + age);
    }

    // Method to display person details
    public void DisplayPersonDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        // Creating a Person object using the parameterized constructor
        Person person1 = new Person("John", 30);
        Console.WriteLine("Person 1 Details:");
        person1.DisplayPersonDetails();

        Console.WriteLine();

        // Creating a Person object using the copy constructor (cloning person1)
        Person person2 = new Person(person1);
        Console.WriteLine("Person 2 Details (Cloned from Person 1):");
        person2.DisplayPersonDetails();
    }
}
