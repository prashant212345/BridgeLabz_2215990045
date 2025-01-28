using System;

class BMIProgram
{
    // Method to calculate BMI for each person and populate the array
    static void CalculateBMI(double[,] personData)
    {
        for (int i = 0; i < personData.GetLength(0); i++)
        {
            // Convert height from cm to meters
            double heightInMeters = personData[i, 1] / 100;

            // Calculate BMI: BMI = weight / (height * height)
            personData[i, 2] = personData[i, 0] / (heightInMeters * heightInMeters);
        }
    }

    // Method to determine BMI status for each person
    static string[] DetermineBMIStatus(double[,] personData)
    {
        string[] status = new string[personData.GetLength(0)];

        for (int i = 0; i < personData.GetLength(0); i++)
        {
            double bmi = personData[i, 2];
            
            if (bmi <= 18.4)
                status[i] = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                status[i] = "Normal";
            else if (bmi >= 25 && bmi <= 39.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        return status;
    }

    static void Main()
    {
        double[,] personData = new double[10, 3]; // Array to store weight, height, and BMI for 10 persons
        string[] bmiStatus = new string[10]; // Array to store BMI status

        // Taking input for weight and height of 10 persons
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter details for person " + (i + 1) + ":");
            Console.Write("Weight (kg): ");
            personData[i, 0] = Convert.ToDouble(Console.ReadLine()); // Weight
            Console.Write("Height (cm): ");
            personData[i, 1] = Convert.ToDouble(Console.ReadLine()); // Height
        }

        // Calculate BMI for each person
        CalculateBMI(personData);

        // Determine BMI status for each person
        bmiStatus = DetermineBMIStatus(personData);

        // Display the results
        Console.WriteLine("\nPerson Details (Weight, Height, BMI, Status):");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Person {i + 1}: Weight = {personData[i, 0]} kg, Height = {personData[i, 1]} cm, BMI = {personData[i, 2]:0.00}, Status = {bmiStatus[i]}");
        }
    }
}
