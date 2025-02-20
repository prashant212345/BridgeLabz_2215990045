using System;
using System.IO;

class LargeFileReader
{
    static string filePath = "large_log.txt";  // Sample large file

    static void Main()
    {
        try
        {
            // Ensure a sample file exists (for testing)
            CreateSampleFile(filePath);

            // Read and process the file line by line
            ReadLargeFile(filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    static void ReadLargeFile(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            int lineNumber = 0;

            while ((line = reader.ReadLine()) != null)
            {
                lineNumber++;
                if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine($"Line {lineNumber}: {line}");
                }
            }
        }
    }

    // Creates a sample large file for testing
    static void CreateSampleFile(string path)
    {
        if (!File.Exists(path))
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 1; i <= 1000000; i++)  // Simulate a large file with 1 million lines
                {
                    if (i % 1000 == 0)
                        writer.WriteLine($"Error found at line {i}");
                    else
                        writer.WriteLine($"This is a regular log entry {i}");
                }
            }
            Console.WriteLine("Sample large file created: 'large_log.txt'");
        }
        else
        {
            Console.WriteLine("Sample large file already exists.");
        }
    }
}
