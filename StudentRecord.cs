using System;

class Student
{
    public int RollNumber;
    public string Name;
    public int Age;
    public string Grade;
    public Student Next;

    public Student(int rollNumber, string name, int age, string grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private Student head;

    // Add student at the beginning
    public void AddAtBeginning(int rollNumber, string name, int age, string grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        newStudent.Next = head;
        head = newStudent;
        Console.WriteLine("Student added at the beginning.");
    }

    // Add student at the end
    public void AddAtEnd(int rollNumber, string name, int age, string grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        if (head == null)
        {
            head = newStudent;
        }
        else
        {
            Student temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;
        }
        Console.WriteLine("Student added at the end.");
    }

    // Add student at a specific position
    public void AddAtPosition(int position, int rollNumber, string name, int age, string grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        if (position == 1)
        {
            newStudent.Next = head;
            head = newStudent;
        }
        else
        {
            Student temp = head;
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            newStudent.Next = temp.Next;
            temp.Next = newStudent;
        }
        Console.WriteLine("Student added at position " + position);
    }

    // Delete student by Roll Number
    public void DeleteStudent(int rollNumber)
    {
        if (head == null)
        {
            Console.WriteLine("No records available.");
            return;
        }

        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            Console.WriteLine("Student record deleted.");
            return;
        }

        Student temp = head;
        while (temp.Next != null && temp.Next.RollNumber != rollNumber)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found.");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student record deleted.");
        }
    }

    // Search student by Roll Number
    public void SearchStudent(int rollNumber)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                Console.WriteLine($"Student Found: Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }

    // Display all students
    public void DisplayStudents()
    {
        if (head == null)
        {
            Console.WriteLine("No records available.");
            return;
        }

        Student temp = head;
        Console.WriteLine("Student Records:");
        while (temp != null)
        {
            Console.WriteLine($"Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }

    // Update student grade by Roll Number
    public void UpdateGrade(int rollNumber, string newGrade)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }
}

class StudentRecord
{
    static void Main()
    {
        StudentLinkedList studentList = new StudentLinkedList();

        while (true)
        {
            Console.WriteLine("\nStudent Record Management");
            Console.WriteLine("1. Add Student at Beginning");
            Console.WriteLine("2. Add Student at End");
            Console.WriteLine("3. Add Student at Position");
            Console.WriteLine("4. Delete Student by Roll Number");
            Console.WriteLine("5. Search Student by Roll Number");
            Console.WriteLine("6. Display All Students");
            Console.WriteLine("7. Update Student Grade");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Roll Number: ");
                    int rollBegin = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string nameBegin = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int ageBegin = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    string gradeBegin = Console.ReadLine();
                    studentList.AddAtBeginning(rollBegin, nameBegin, ageBegin, gradeBegin);
                    break;

                case 2:
                    Console.Write("Enter Roll Number: ");
                    int rollEnd = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string nameEnd = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int ageEnd = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    string gradeEnd = Console.ReadLine();
                    studentList.AddAtEnd(rollEnd, nameEnd, ageEnd, gradeEnd);
                    break;

                case 3:
                    Console.Write("Enter Position: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Roll Number: ");
                    int rollPos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string namePos = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int agePos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    string gradePos = Console.ReadLine();
                    studentList.AddAtPosition(position, rollPos, namePos, agePos, gradePos);
                    break;

                case 4:
                    Console.Write("Enter Roll Number to delete: ");
                    int rollDel = Convert.ToInt32(Console.ReadLine());
                    studentList.DeleteStudent(rollDel);
                    break;

                case 5:
                    Console.Write("Enter Roll Number to search: ");
                    int rollSearch = Convert.ToInt32(Console.ReadLine());
                    studentList.SearchStudent(rollSearch);
                    break;

                case 6:
                    studentList.DisplayStudents();
                    break;

                case 7:
                    Console.Write("Enter Roll Number to update grade: ");
                    int rollUpdate = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter New Grade: ");
                    string newGrade = Console.ReadLine();
                    studentList.UpdateGrade(rollUpdate, newGrade);
                    break;

                case 8:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
