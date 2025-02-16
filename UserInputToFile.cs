using System;
using System.IO;

public class UserInputToFile
{
	static void Main()
	{
		string filePath = "UserInput.txt";
		Console.WriteLine("Enter Text to save to the file (Type 'exit' to stop)");

		try
		{
			using (StreamWriter writer = new StreamWriter(filePath, false)) // Overwrite Existing File
			{
				while (true)
				{
					string inp = Console.ReadLine();
					if (inp.ToLower() == "exit") // Stop when 'exit' is typed
						break;

					writer.WriteLine(inp);
				}
			}
			Console.WriteLine($"User Input has been saved to '{filePath}'.");
		}
		catch (Exception e)
		{
			Console.WriteLine("Error writing to file : " + e.Message);
		}
	}
}
