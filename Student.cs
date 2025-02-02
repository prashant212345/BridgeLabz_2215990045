using System;

class Student
{
    // Public: Can be accessed from anywhere
    public int rollNumber;

    // Protected: Can be accessed in this class and derived classes
    protected string name;

    // Private: Can only be accessed within this class
    private double CGPA;

    // Constructor to initialize student details
    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Public Method: Get CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public Method: Set CGPA
    public void SetCGPA(double newCGPA)
    {
        if (newCGPA >= 0.0 && newCGPA <= 10.0) // Valid range check
        {
            CGPA = newCGPA;
        }
        else
        {
            Console.WriteLine("Invalid CGPA! Please enter a value between 0.0 and 10.0.");
        }
    }

    // Public Method: Display Student Details
    public void DisplayStudentDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + CGPA);
        Console.WriteLine();
    }
}

// Derived Class: Demonstrating use of protected member
class PostgraduateStudent : Student
{
    private string specialization;

    // Constructor
    public PostgraduateStudent(int rollNumber, string name, double CGPA, string specialization)
        : base(rollNumber, name, CGPA)
    {
        this.specialization = specialization;
    }

    // Method to Display Postgraduate Student Details
    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Postgraduate Student Details:");
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name); // Accessing protected member
        Console.WriteLine("Specialization: " + specialization);
        Console.WriteLine();
    }
}

// Main Method
class Program
{
    static void Main()
    {
        // Creating Student Object
        Student student1 = new Student(101, "Rahul", 8.5);

        // Displaying student details
        Console.WriteLine("Student Details:");
        student1.DisplayStudentDetails();

        // Modifying CGPA using public setter method
        student1.SetCGPA(9.2);
        Console.WriteLine("After Updating CGPA:");
        student1.DisplayStudentDetails();

        // Creating PostgraduateStudent Object
        PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Anjali", 9.0, "Computer Science");

        // Display postgraduate student details
        pgStudent.DisplayPostgraduateDetails();
    }
}
