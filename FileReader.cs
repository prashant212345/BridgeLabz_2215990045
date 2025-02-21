using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        string fileName = "data.txt";

        try
        {
            // Open the file for reading
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}