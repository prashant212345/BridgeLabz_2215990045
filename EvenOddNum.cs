using System;

class EvenOddNum{
    static void Main(){
        // Declare the variable to store the user's input number
        int number;
        
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        
        // Try to parse the input, if it fails print an error and exit
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Error: Please enter a valid natural number greater than zero.");
            return; // Exit the program if the input is not valid
        }

        // Create arrays for even and odd numbers with appropriate size
        int[] evenNumbers = new int[number / 2 + 1];
        int[] oddNumbers = new int[number / 2 + 1];

        // Declare index variables for both arrays
        int evenIndex = 0;
        int oddIndex = 0;

        // Iterate from 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            // Check if the number is even or odd and store it in the corresponding array
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++; // Increment the even index
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++; // Increment the odd index
            }
        }

        // Print the odd numbers
        Console.WriteLine("\nOdd numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        // Print the even numbers
        Console.WriteLine("\nEven numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
