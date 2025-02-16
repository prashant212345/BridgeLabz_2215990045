using System;
using System.IO;

public class ReadFileLineByLine
{
    static void Main()
    {
        string filePath = "Sample.txt"; // File to read

        try
        {
            // Ensure the file exists before reading
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File '{filePath}' not found. Creating a sample file...");
                File.WriteAllText(filePath, "Hello, this is the first line.\nThis is the second line.\nEnd of file.");
            }

            // Read file line by line using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }
    }
}