using System;
using System.Collections.Generic;

// Abstract class Employee
abstract class Employee
{
    private int employeeId;
    private string name;
    private double baseSalary;

    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Base Salary: " + baseSalary);
        Console.WriteLine("Total Salary: " + CalculateSalary());
    }
}

// Interface IDepartment
interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// FullTimeEmployee subclass
class FullTimeEmployee : Employee, IDepartment
{
    private string department;
    private double bonus;

    public double Bonus
    {
        get { return bonus; }
        set { bonus = value; }
    }

    public FullTimeEmployee(int employeeId, string name, double baseSalary, double bonus)
        : base(employeeId, name, baseSalary)
    {
        this.bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + bonus;
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + department;
    }
}

// PartTimeEmployee subclass
class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int hoursWorked;
    private double hourlyRate;

    public int HoursWorked
    {
        get { return hoursWorked; }
        set { hoursWorked = value; }
    }

    public double HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public PartTimeEmployee(int employeeId, string name, double hourlyRate, int hoursWorked)
        : base(employeeId, name, 0)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + department;
    }
}

// Main Program
class EmployeeProg
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        FullTimeEmployee emp1 = new FullTimeEmployee(101, "Alice", 50000, 10000);
        emp1.AssignDepartment("HR");
        employees.Add(emp1);

        PartTimeEmployee emp2 = new PartTimeEmployee(102, "Bob", 500, 20);
        emp2.AssignDepartment("IT");
        employees.Add(emp2);

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
            IDepartment dept = emp as IDepartment;
            if (dept != null)
            {
                Console.WriteLine(dept.GetDepartmentDetails());
            }
            Console.WriteLine("-------------------------");
        }
    }
}
