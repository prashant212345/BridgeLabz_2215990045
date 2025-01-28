using System;

public class StudentVoteChecker
{
    // Method to check if the student can vote
    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false; // Negative age is invalid, cannot vote
        }
        if (age >= 18)
        {
            return true; // Age 18 or above, can vote
        }
        return false; // Age below 18, cannot vote
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of StudentVoteChecker
        StudentVoteChecker voteChecker = new StudentVoteChecker();

        // Array to store ages of 10 students
        int[] studentAges = new int[10];

        // Loop to take input for ages of all students
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            studentAges[i] = int.Parse(Console.ReadLine());
        }

        // Display voting eligibility for each student
        Console.WriteLine("\nVoting eligibility of students:");
        for (int i = 0; i < studentAges.Length; i++)
        {
            bool canVote = voteChecker.CanStudentVote(studentAges[i]);
            if (studentAges[i] < 0)
            {
                Console.WriteLine($"Student {i + 1}: Invalid age entered.");
            }
            else
            {
                Console.WriteLine($"Student {i + 1}: {(canVote ? "Can vote" : "Cannot vote")}");
            }
        }
    }
}
