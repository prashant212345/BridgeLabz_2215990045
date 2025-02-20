using System;
using System.IO;

class StudentDataStream
{
    static string filePath = "students.dat";  // Binary file to store data

    static void Main()
    {
        try
        {
            // Step 1: Store student details
            StoreStudentData();
            Console.WriteLine("Student data stored successfully.\n");

            // Step 2: Retrieve and display student details
            RetrieveStudentData();
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    static void StoreStudentData()
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(101);              // Roll number
            writer.Write("Alice Johnson");  // Name
            writer.Write(3.85f);            // GPA

            writer.Write(102);
            writer.Write("Bob Smith");
            writer.Write(3.65f);

            writer.Write(103);
            writer.Write("Charlie Brown");
            writer.Write(3.92f);
        }
    }

    static void RetrieveStudentData()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No student data found.");
            return;
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            Console.WriteLine("Retrieved Student Details:\n");

            while (fs.Position < fs.Length)
            {
                int rollNumber = reader.ReadInt32();
                string name = reader.ReadString();
                float gpa = reader.ReadSingle();

                Console.WriteLine($"Roll No: {rollNumber}, Name: {name}, GPA: {gpa}");
            }
        }
    }
}
