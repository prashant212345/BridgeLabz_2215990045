using System;

class StudentGrade
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Create a 2D array to store marks for Physics, Chemistry, and Maths
        int[,] marks = new int[numStudents, 3];
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("Enter marks for Student " + (i + 1) + ":");

            marks[i, 0] = GetValidMarks("Physics");
            marks[i, 1] = GetValidMarks("Chemistry");
            marks[i, 2] = GetValidMarks("Maths");

            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = totalMarks / 3.0;

            grades[i] = CalculateGrade(percentages[i]);
        }

        Console.WriteLine("\nStudent Results:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine((i + 1) + "\t" + marks[i, 0] + "\t" + marks[i, 1] + "\t\t" + marks[i, 2] +
                              "\t" + percentages[i] + "\t\t" + grades[i]);
        }
    }

    static int GetValidMarks(string subject)
    {
        int marks;
        while (true)
        {
            Console.Write("Enter marks in " + subject + ": ");
            marks = int.Parse(Console.ReadLine());
            if (marks >= 0) break;
            Console.WriteLine("Marks cannot be negative. Please enter positive values.");
        }
        return marks;
    }

    static char CalculateGrade(double percentage)
    {
        if (percentage >= 80) return 'A';
        if (percentage >= 70) return 'B';
        if (percentage >= 60) return 'C';
        if (percentage >= 50) return 'D';
        if (percentage >= 40) return 'E';
        return 'R';
    }
}
