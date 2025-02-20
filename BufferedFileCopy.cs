using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy
{
    static void Main()
    {
        string sourceFile = "largefile.bin";   // Large file (100MB)
        string destBuffered = "buffered_copy.bin";
        string destUnbuffered = "unbuffered_copy.bin";

        // Step 1: Ensure the large file exists (100MB)
        CreateLargeFile(sourceFile, 100 * 1024 * 1024); // 100MB

        // Step 2: Measure time for Buffered Copy
        Stopwatch stopwatch = Stopwatch.StartNew();
        CopyWithBufferedStream(sourceFile, destBuffered);
        stopwatch.Stop();
        Console.WriteLine($"Buffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");

        // Step 3: Measure time for Unbuffered Copy
        stopwatch.Restart();
        CopyWithFileStream(sourceFile, destUnbuffered);
        stopwatch.Stop();
        Console.WriteLine($"Unbuffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");
    }

    // Method to create a large file (filled with dummy data)
    static void CreateLargeFile(string filePath, int fileSize)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine("Large file already exists.");
            return;
        }

        Console.WriteLine("Creating large file (100MB)...");
        byte[] buffer = new byte[4096]; // 4 KB chunks
        Random random = new Random();

        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            for (int i = 0; i < fileSize / buffer.Length; i++)
            {
                random.NextBytes(buffer); // Fill buffer with random data
                fs.Write(buffer, 0, buffer.Length);
            }
        }
        Console.WriteLine("Large file created successfully.");
    }

    // Buffered copy method using BufferedStream
    static void CopyWithBufferedStream(string source, string destination)
    {
        const int bufferSize = 4096; // 4 KB buffer size

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (BufferedStream bsRead = new BufferedStream(fsRead, bufferSize))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite, bufferSize))
        {
            byte[] buffer = new byte[bufferSize];
            int bytesRead;

            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }
    }

    // Unbuffered copy method using FileStream directly
    static void CopyWithFileStream(string source, string destination)
    {
        const int bufferSize = 4096; // 4 KB buffer size

        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[bufferSize];
            int bytesRead;

            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }
    }
}
