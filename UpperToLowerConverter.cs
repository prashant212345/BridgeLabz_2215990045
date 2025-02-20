using System;
using System.IO;
using System.Text;

class UpperToLowerConverter
{
    static string inputFile = "input.txt";   // Source file
    static string outputFile = "output.txt"; // Destination file

    static void Main()
    {
        try
        {
            // Ensure the input file exists
            CreateSampleFile(inputFile);

            // Convert uppercase to lowercase while reading and writing efficiently
            ConvertUppercaseToLowercase(inputFile, outputFile);
            Console.WriteLine("File converted successfully. Check 'output.txt'.");
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

    static void ConvertUppercaseToLowercase(string sourcePath, string destinationPath)
    {
        using (FileStream inputFileStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
        using (BufferedStream bufferedInput = new BufferedStream(inputFileStream))
        using (StreamReader reader = new StreamReader(bufferedInput, Encoding.UTF8))
        using (FileStream outputFileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedOutput = new BufferedStream(outputFileStream))
        using (StreamWriter writer = new StreamWriter(bufferedOutput, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }
        }
    }

    // Creates a sample input file if it doesn't exist
    static void CreateSampleFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine("HELLO WORLD!");
                writer.WriteLine("THIS IS A SAMPLE FILE.");
                writer.WriteLine("C# PROGRAMMING IS FUN.");
            }
            Console.WriteLine("Sample input file created: 'input.txt'");
        }
        else
        {
            Console.WriteLine("Sample input file already exists.");
        }
    }
}
