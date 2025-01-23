using System;

class PrimeNumber
{
    static void Main()
    {
        // Input a number
        Console.WriteLine("Enter a number to check if it is a prime number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is greater than 1
        if (number <= 1)
        {
            Console.WriteLine(number + " is not a prime number.");
        }
        else
        {
            // Initialize isPrime to true
            bool isPrime = true;

            // Loop from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break; // Exit the loop as the number is not prime
                }
            }

            // Output the result
            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
    }
}
