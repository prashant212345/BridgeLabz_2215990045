using System;

class Employee{
	
    // Static variable shared by all employees
	private static string CompanyName = "Capgemini India Pvt Ltd";
	private static int totalEmployee = 0;
	
    // Readonly variable for employee ID
	public readonly int Id;
	public string Name;
	public string Designation;
	
    // Constructor using 'this' keyword
	public Employee(int id, string name, string designation){
		this.Id = id;
		this.Name = name;
		this.Designation = designation;
		totalEmployee++;
	}
	
    // Static method to display total employees
	public static void DisplayTotalEmployee(){
		Console.WriteLine("Total Employees: "+totalEmployee);
	}
	
    // Method to display employee details using 'is' operator
	public void DisplayEmployeeDetails(){
		if (this is Employee){
            Console.WriteLine("Company Name: " + CompanyName);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine();
        }
	}
	
	static void Main(){
		// Display company name
        Console.WriteLine(Employee.CompanyName);
        Console.WriteLine();

        // Creating employee objects
        Employee emp1 = new Employee(101, "Amar", "SE");
        Employee emp2 = new Employee(102, "Akbar", "ASE");

        // Display employee details
        emp1.DisplayEmployeeDetails();
        emp2.DisplayEmployeeDetails();

        // Display total employees
        Employee.DisplayTotalEmployee();
	}
}