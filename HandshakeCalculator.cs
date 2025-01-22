using System;

class HandshakeCalculator{
    // Main method
    static void Main(String[] args){
        // Prompt the user to enter the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the combination formula
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Display the result
        Console.WriteLine("The maximum number of handshakes among "+(numberOfStudents)+" students is "+(handshakes));
    }
}
