using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        string filePath = "user_info.txt"; // File to store user details

        try
        {
            // Using StreamReader to read from the console
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            {
                Console.Write("Enter your name: ");
                string name = reader.ReadLine();

                Console.Write("Enter your age: ");
                int age;
                while (!int.TryParse(reader.ReadLine(), out age))
                {
                    Console.Write("Invalid input. Please enter a valid age: ");
                }

                Console.Write("Enter your favorite programming language: ");
                string language = reader.ReadLine();

                // Using StreamWriter to write data to file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("User Details:");
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Age: {age}");
                    writer.WriteLine($"Favorite Programming Language: {language}");
                }

                Console.WriteLine("\nUser data saved successfully in 'user_info.txt'!");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File error: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Input error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
