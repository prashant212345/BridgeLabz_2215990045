using System;

public class Employee
{
    // Public member variable: employeeID
    public int employeeID;

    // Protected member variable: department (only accessible by this class and derived classes)
    protected string department;

    // Private member variable: salary (only accessible within this class)
    private decimal salary;

    // Constructor to initialize employee details
    public Employee(int id, string dept, decimal sal)
    {
        employeeID = id;
        department = dept;
        salary = sal;
    }

    // Public method to modify salary
    public void ModifySalary(decimal newSalary)
    {
        salary = newSalary;
    }

    // Public method to get the salary
    public decimal GetSalary()
    {
        return salary;
    }
}

// Subclass Manager inheriting from Employee
public class Manager : Employee
{
    // Constructor to initialize manager-specific details
    public Manager(int id, string dept, decimal sal) : base(id, dept, sal)
    {
    }

    // Method to display employee details (can access employeeID and department from Employee class)
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + GetSalary());
    }
}

class Program
{
    static void Main()
    {
        // Create an Employee object and modify salary
        Employee emp1 = new Employee(101, "IT", 50000m);
        Console.WriteLine("Original Salary: " + emp1.GetSalary());
        emp1.ModifySalary(55000m);
        Console.WriteLine("Modified Salary: " + emp1.GetSalary());

        Console.WriteLine();

        // Create a Manager object and display details
        Manager mgr1 = new Manager(102, "HR", 75000m);
        mgr1.DisplayEmployeeDetails();
    }
}
