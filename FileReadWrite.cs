using System;
using System.IO;

class FileReadWrite
{
    static void Main()
    {
        string sourceFile = "source.txt";  // Change to your file path if needed
        string destinationFile = "destination.txt";

        try
        {
            // Check if source file exists
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Open the source file for reading
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fsRead))
            {
                string content = reader.ReadToEnd(); // Read entire file content

                // Open the destination file for writing
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsWrite))
                {
                    writer.Write(content);
                }

                Console.WriteLine("File copied successfully!");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
