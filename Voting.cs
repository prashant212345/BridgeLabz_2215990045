using System;

class Voting
{
    static void Main()
    {
        // Input: Prompt the user to enter their age
        Console.Write("Enter the person's age: ");
        string input = Console.ReadLine();

        // Check if the input is a valid integer
        if (int.TryParse(input, out int age))
        {
            // Check if the person can vote
            if (age >= 18)
            {
                Console.WriteLine("The person's age is " + age + " and can vote.");
            }
            else
            {
                Console.WriteLine("The person's age is " + age + " and cannot vote.");
            }
        }
        else
        {
            // If the input is not a valid integer
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
