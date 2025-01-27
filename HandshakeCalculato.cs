using System;

class HandshakeCalculato
{
    static void Main()
    {
        // Prompting user to input the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Calculating the maximum number of handshakes
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Displaying the result
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + maxHandshakes + ".");
    }
}
