using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class EmployeeManagement
    {
        public static void Main()
        {
            Employee manager = new Manager("Alice", 101, 75000, 10);
            Employee developer = new Developer("Bob", 102, 60000, "C#");
            Employee intern = new Intern("Charlie", 103, 20000, "6 months");

            manager.DisplayDetails();
            developer.DisplayDetails();
            intern.DisplayDetails();
        }
    }
    internal class Employee
    {
        public string Name {  get; set; }
        public int ID {  get; set; }
        public double Salary {  get; set; }
        public Employee(string name, int id, double salary) { 
            Name = name;
            ID = id;
            Salary = salary;
        }
        public virtual void DisplayDetails() {
            Console.WriteLine("Name: {0}, ID: {1}, Salary: {2}", Name, ID, Salary);
        }

    }
    class Manager : Employee { 
        public int TeamSize {  get; set; }
        public Manager(string name, int id, double salary, int teamsize) : base(name, id, salary) { 
            TeamSize = teamsize;
        }
        public override void DisplayDetails(){
            Console.WriteLine("Name: {0}, ID: {1}, Salary: {2}", Name, ID, Salary);
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Name: {0}, ID: {1}, Salary: {2}, ProgrammingLanguage: {3}", Name, ID, Salary, ProgrammingLanguage);
        }
    }
    class Intern : Employee
    {
        public string InternshipDuration { get; set; }
        public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
        {
            InternshipDuration = internshipDuration;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Name: {0}, ID: {1}, Salary: {2}, InternshipDuration: {3}", Name, ID, Salary, InternshipDuration);
        }
    }
}
