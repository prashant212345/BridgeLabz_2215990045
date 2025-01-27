using System;

class SmallestAndLargest
{
    static void Main()
    {
        // Taking user input for three numbers
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        // Finding the smallest and largest numbers
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Displaying the results
        Console.WriteLine("The smallest number is: " + result[0]);
        Console.WriteLine("The largest number is: " + result[1]);
    }

    // Method to find the smallest and largest numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));
        return new int[] { smallest, largest };
    }
}
