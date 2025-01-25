using System;

class LargestNum
{
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Define initial array size
        int maxDigits = 10;
        int[] digits = new int[maxDigits];

        // Define index variable for storing digits in the array
        int index = 0;

        // Loop to store digits of the number in the array
        while (number != 0)
        {
            // Check if the index exceeds the current maxDigits, then increase the array size
            if (index == maxDigits)
            {
                // Increase the size of the array by 10
                maxDigits += 10;
                
                // Create a temporary array with the new size
                int[] temp = new int[maxDigits];

                // Copy the elements from the old array to the new temp array
                Array.Copy(digits, temp, digits.Length);

                // Assign the temp array to the digits array
                digits = temp;
            }

            // Store the last digit of the number
            digits[index] = number % 10;
            number /= 10;  // Remove the last digit from the number
            index++;  // Increment the index
        }

        // Variables to store the largest and second largest digits
        int largest = -1;
        int secondLargest = -1;

        // Loop through the array to find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] < largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display the largest and second largest digits
        Console.WriteLine("Largest digit: "+(largest));
        Console.WriteLine("Second largest digit: "+(secondLargest));
    }
}
