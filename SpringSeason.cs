using System;

class SpringSeason
{
    static void Main()
    {
        Console.Write("Enter the month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the day (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = CheckSpringSeason(month, day);

        if (isSpring)
            Console.WriteLine("It's a Spring Season.");
        else
            Console.WriteLine("Not a Spring Season.");
    }

    static bool CheckSpringSeason(int month, int day)
    {
        // Spring Season: March 20 to June 20
        if ((month == 3 && day >= 20) || 
            (month > 3 && month < 6) || 
            (month == 6 && day <= 20))
        {
            return true;
        }
        return false;
    }
}
