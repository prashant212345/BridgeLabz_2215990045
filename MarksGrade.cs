using System;

class MarksGrade
{
    static void Main()
    {
        // Input marks for three subjects
        Console.WriteLine("Enter marks for Physics:");
        int physics = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter marks for Chemistry:");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter marks for Mathematics:");
        int mathematics = Convert.ToInt32(Console.ReadLine());

        // Calculate total, percentage and average marks
        int total = physics + chemistry + mathematics;
        float percentage = (total / 3.0f);

        // Determine grade and remarks
        char grade;
        string remarks;

        if (percentage >= 80)
        {
            grade = 'A';
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = 'B';
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = 'C';
            remarks = "Level 2, below but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = 'D';
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = 'E';
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = 'R';
            remarks = "Remedial standards";
        }

        // Output results
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Percentage: " + percentage + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);
    }
}
