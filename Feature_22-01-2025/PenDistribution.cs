using System;

class PenDistribution{
    // Main method
    static void Main(String[] args){
        // Total number of pens
        int totalPens = 14;
        // Total number of students
        int students = 3;

        // Display the results
        Console.WriteLine("The Pen Per Student is " + (totalPens/students) + " and the remaining pen not distributed is " + (totalPens%students));
    }
}
