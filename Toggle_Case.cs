using System;

class Toggle_Case
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter any string:");
        string inp = Console.ReadLine();

        // Call the method to toggle case and display the result
        Console.WriteLine("Toggled Case: " + StrToggle(inp));
    }

    // Method to toggle the case of each letter in the input string
    static string StrToggle(string inp)
    {
        // Convert string to a character array for modification
        char[] arr = inp.ToCharArray();

        // Loop through each character in the array
        for (int i = 0; i < arr.Length; i++)
        {
            // If the character is a lowercase letter ('a' to 'z'), convert it to uppercase
            if (arr[i] >= 'a' && arr[i] <= 'z')
            {
                arr[i] = (char)(arr[i] - 'a' + 'A'); // Convert lowercase to uppercase
            }
            // If the character is an uppercase letter ('A' to 'Z'), convert it to lowercase
            else if (arr[i] >= 'A' && arr[i] <= 'Z')
            {
                arr[i] = (char)(arr[i] - 'A' + 'a'); // Convert uppercase to lowercase
            }
        }

        return new string(arr);
    }
}
