using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStreamExample
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString()))
        {
            Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
            Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteToPipe(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe))
            {
                writer.AutoFlush = true;

                for (int i = 1; i <= 5; i++)
                {
                    string message = $"Message {i} from Writer";
                    Console.WriteLine($"Writer: {message}");
                    writer.WriteLine(message);
                    Thread.Sleep(500); // Simulate processing delay
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Write error: {ex.Message}");
        }
    }

    static void ReadFromPipe(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Reader received: {line}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Read error: {ex.Message}");
        }
    }
}
