using System;

class TextNode
{
    public string Content;
    public TextNode Prev;
    public TextNode Next;

    public TextNode(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextNode head = null;
    private TextNode current = null;
    private int historyLimit = 10; // Limit undo/redo history

    // Add a new text state
    public void AddState(string content)
    {
        TextNode newNode = new TextNode(content);

        if (head == null) // If the list is empty
        {
            head = newNode;
            current = newNode;
        }
        else
        {
            current.Next = newNode;
            newNode.Prev = current;
            current = newNode;
        }

        // Trim history if it exceeds the limit
        TrimHistory();
    }

    // Undo Functionality: Move to the previous state
    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine($"Undo: {current.Content}");
        }
        else
        {
            Console.WriteLine("No more undo steps available.");
        }
    }

    // Redo Functionality: Move to the next state
    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine($"Redo: {current.Content}");
        }
        else
        {
            Console.WriteLine("No more redo steps available.");
        }
    }

    // Display the current text content
    public void DisplayCurrentState()
    {
        if (current != null)
            Console.WriteLine($"Current Text: {current.Content}");
        else
            Console.WriteLine("No text available.");
    }

    // Trim history to keep only the last 10 states
    private void TrimHistory()
    {
        int count = 0;
        TextNode temp = head;

        // Count total nodes
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        // If history exceeds limit, remove oldest nodes
        while (count > historyLimit)
        {
            head = head.Next;
            if (head != null)
                head.Prev = null;
            count--;
        }
    }
}

class UndoText
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        while (true)
        {
            Console.WriteLine("\nText Editor with Undo/Redo:");
            Console.WriteLine("1. Type Text");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Redo");
            Console.WriteLine("4. Display Current State");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter new text: ");
                    string text = Console.ReadLine();
                    editor.AddState(text);
                    break;

                case 2:
                    editor.Undo();
                    break;

                case 3:
                    editor.Redo();
                    break;

                case 4:
                    editor.DisplayCurrentState();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
