using System;
using System.Drawing;  // Requires System.Drawing.Common for .NET Core
using System.IO;

class ImageByteArrayConverter
{
    static string originalImagePath = "sample_image.png";  // Original image
    static string outputImagePath = "output_image.png";    // New image file

    static void Main()
    {
        try
        {
            // Ensure the sample image exists
            CreateSampleImage(originalImagePath);

            // Convert image to byte array
            byte[] imageBytes = ImageToByteArray(originalImagePath);
            Console.WriteLine($"Image converted to byte array (Size: {imageBytes.Length} bytes)");

            // Convert byte array back to image
            ByteArrayToImage(imageBytes, outputImagePath);
            Console.WriteLine("Image successfully written back to 'output_image.png'");

            // Verify the new file matches the original
            if (VerifyFiles(originalImagePath, outputImagePath))
                Console.WriteLine("Verification successful: The images are identical.");
            else
                Console.WriteLine("Verification failed: The images are different.");
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

    // Converts an image file to a byte array using MemoryStream
    static byte[] ImageToByteArray(string filePath)
    {
        using (MemoryStream ms = new MemoryStream())
        using (Image img = Image.FromFile(filePath))
        {
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }
    }

    // Converts a byte array back to an image and saves it to disk
    static void ByteArrayToImage(byte[] imageBytes, string filePath)
    {
        using (MemoryStream ms = new MemoryStream(imageBytes))
        using (Image img = Image.FromStream(ms))
        {
            img.Save(filePath);
        }
    }

    // Creates a simple black image if the original file does not exist
    static void CreateSampleImage(string filePath)
    {
        if (!File.Exists(filePath))
        {
            using (Bitmap bmp = new Bitmap(200, 200))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                bmp.Save(filePath);
            }
            Console.WriteLine("Sample image created: 'sample_image.png'");
        }
        else
        {
            Console.WriteLine("Sample image already exists.");
        }
    }

    // Verifies that two files are identical
    static bool VerifyFiles(string file1, string file2)
    {
        byte[] file1Bytes = File.ReadAllBytes(file1);
        byte[] file2Bytes = File.ReadAllBytes(file2);
        return StructuralComparisons.StructuralEqualityComparer.Equals(file1Bytes, file2Bytes);
    }
}
