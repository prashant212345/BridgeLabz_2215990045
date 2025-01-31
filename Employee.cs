using System;

public class Employee
{
    // Fields (Attributes)
    private string name;
    private int id;
    private double salary;

    // Constructor
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee Salary: " + salary);
    }
}

// Main Class to Test
public class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee("John Doe", 101, 50000);
        emp1.DisplayDetails();
    }
}
