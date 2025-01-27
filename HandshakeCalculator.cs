using System;

class HandshakeCalculator
{
    static void Main()
    {
        // Taking user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculating the maximum number of handshakes
        int maxHandshakes = CalculateHandshakes(numberOfStudents);

        // Displaying the result
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + maxHandshakes + ".");
    }

    // Method to calculate the number of handshakes using the formula
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}
