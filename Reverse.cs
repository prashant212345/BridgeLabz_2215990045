using System;

class Reverse
{
    static void Main()
    {
        // Prompt user to enter a string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Call ReverseString method and print the result
        string reversedWord = ReverseString(input);
        Console.WriteLine("Reversed string: " + reversedWord);
    }

    static string ReverseString(string input)
    {
        // Convert string to character array
        char[] arr = input.ToCharArray();

        // Two-pointer approach to reverse the array
        int i = 0;
        int j = arr.Length - 1;

        while (i < j)
        {
            // Swap characters
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            // Move pointers
            i++;
            j--;
        }

        // Convert character array back to string and return
        return new string(arr);
    }
}