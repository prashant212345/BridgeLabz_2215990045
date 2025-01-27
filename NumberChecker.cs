using System;

class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumber(number);

        if (result == 1)
            Console.WriteLine("The number is positive.");
        else if (result == -1)
            Console.WriteLine("The number is negative.");
        else
            Console.WriteLine("The number is zero.");
    }

    static int CheckNumber(int num)
    {
        if (num > 0)
            return 1;
        else if (num < 0)
            return -1;
        else
            return 0;
    }
}
