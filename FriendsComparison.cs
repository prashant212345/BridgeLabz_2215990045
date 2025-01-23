using System;

class FriendsComparison
{
    static void Main()
    {
        // Input for Amar
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height in cm: ");
        int amarHeight = int.Parse(Console.ReadLine());

        // Input for Akbar
        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height in cm: ");
        int akbarHeight = int.Parse(Console.ReadLine());

        // Input for Anthony
        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height in cm: ");
        int anthonyHeight = int.Parse(Console.ReadLine());

        // Find the youngest friend
        int youngestAge = amarAge;
        string youngestFriend = "Amar";

        if (akbarAge < youngestAge)
        {
            youngestAge = akbarAge;
            youngestFriend = "Akbar";
        }
        if (anthonyAge < youngestAge)
        {
            youngestAge = anthonyAge;
            youngestFriend = "Anthony";
        }

        // Find the tallest friend
        int tallestHeight = amarHeight;
        string tallestFriend = "Amar";

        if (akbarHeight > tallestHeight)
        {
            tallestHeight = akbarHeight;
            tallestFriend = "Akbar";
        }
        if (anthonyHeight > tallestHeight)
        {
            tallestHeight = anthonyHeight;
            tallestFriend = "Anthony";
        }

        // Display the results
        Console.WriteLine("The youngest friend is " + youngestFriend + " with age " + youngestAge + ".");
        Console.WriteLine("The tallest friend is " + tallestFriend + " with height " + tallestHeight + " cm.");
    }
}
