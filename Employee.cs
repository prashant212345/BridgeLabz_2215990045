using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static string filePath = "employees.json";

    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 70000 },
            new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 65000 }
        };

        SerializeEmployees(employees);
        Console.WriteLine("\n✅ Employees saved successfully!");

        List<Employee> retrievedEmployees = DeserializeEmployees();
        Console.WriteLine("\n📂 Retrieved Employee Data:");
        foreach (var emp in retrievedEmployees)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
        }
    }

    static void SerializeEmployees(List<Employee> employees)
    {
        try
        {
            string jsonString = JsonConvert.SerializeObject(employees, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"❌ File error: {ex.Message}");
        }
    }

    static List<Employee> DeserializeEmployees()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("❌ Employee file not found.");
                return new List<Employee>();
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Employee>>(jsonString) ?? new List<Employee>();
        }
        catch (IOException ex)
        {
            Console.WriteLine($"❌ File error: {ex.Message}");
            return new List<Employee>();
        }
    }
}
