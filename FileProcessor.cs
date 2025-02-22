using System;
using System.IO;
using NUnit.Framework;

public class FileProcessor
{
    public void WriteToFile(string filename, string content) { File.WriteAllText(filename, content); }
    public string ReadFromFile(string filename) { return File.ReadAllText(filename); }
}

[TestFixture]
public class FileProcessorTests
{
    private const string FilePath = "test.txt";
    private FileProcessor _processor;

    [SetUp]
    public void Setup() { _processor = new FileProcessor(); }

    [Test]
    public void Test_WriteAndReadFile()
    {
        _processor.WriteToFile(FilePath, "Hello World");
        Assert.AreEqual("Hello World", _processor.ReadFromFile(FilePath));
    }

    [Test]
    public void Test_FileExists()
    {
        _processor.WriteToFile(FilePath, "Hello");
        Assert.IsTrue(File.Exists(FilePath));
    }
}
