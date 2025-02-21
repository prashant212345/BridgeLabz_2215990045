using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        string fileName = "info.txt";

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}