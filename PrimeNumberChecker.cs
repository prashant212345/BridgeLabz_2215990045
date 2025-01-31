using System;

class PrimeNumberChecker
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        // Call the function to check for prime number
        bool isPrime = CheckPrime(num);

        // Display the result
        if (isPrime)
        {
            Console.WriteLine(num + " is a prime number.");
        }
        else
        {
            Console.WriteLine(num + " is not a prime number.");
        }
    }

    // Function to check if a number is prime
    static bool CheckPrime(int number)
    {
        if (number <= 1)
        {
            return false; // 0 and 1 are not prime numbers
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false; // Number is divisible by 'i', so it's not prime
            }
        }

        return true; // Number is prime
    }
}
