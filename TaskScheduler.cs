using System;

class TaskNode
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public TaskNode Next;

    public TaskNode(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head = null;
    private TaskNode currentTask = null;

    // Add a task at the beginning
    public void AddAtBeginning(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            newTask.Next = head;
            currentTask = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
            head = newTask;
        }
        Console.WriteLine("Task added at the beginning.");
    }

    // Add a task at the end
    public void AddAtEnd(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskID, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            newTask.Next = head;
            currentTask = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
        }
        Console.WriteLine("Task added at the end.");
    }

    // Display all tasks
    public void DisplayTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        TaskNode temp = head;
        Console.WriteLine("\nTask List:");
        do
        {
            Console.WriteLine($"ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate.ToShortDateString()}");
            temp = temp.Next;
        } while (temp != head);
    }
}

class TaskScheduler
{
    static void Main()
    {
        TaskScheduler taskList = new TaskScheduler();

        while (true)
        {
            Console.WriteLine("\nTask Scheduler System");
            Console.WriteLine("1. Add Task at Beginning");
            Console.WriteLine("2. Add Task at End");
            Console.WriteLine("3. Display All Tasks");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Task ID: ");
                    int taskID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    string taskName1 = Console.ReadLine();
                    Console.Write("Enter Priority (1-5): ");
                    int priority1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-mm-dd): ");
                    DateTime dueDate1 = DateTime.Parse(Console.ReadLine());

                    taskList.AddAtBeginning(taskID1, taskName1, priority1, dueDate1);
                    break;

                case 2:
                    Console.Write("Enter Task ID: ");
                    int taskID2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    string taskName2 = Console.ReadLine();
                    Console.Write("Enter Priority (1-5): ");
                    int priority2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-mm-dd): ");
                    DateTime dueDate2 = DateTime.Parse(Console.ReadLine());

                    taskList.AddAtEnd(taskID2, taskName2, priority2, dueDate2);
                    break;

                case 3:
                    Console.Write("Enter Task ID: ");
                    int taskID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    string taskName = Console.ReadLine();
                    Console.Write("Enter Priority (1-5): ");
                    int priority = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-mm-dd): ");
                    DateTime dueDate = DateTime.Parse(Console.ReadLine());

                    if (choice == 1) taskList.AddAtBeginning(taskID, taskName, priority, dueDate);
                    else if (choice == 2) taskList.AddAtEnd(taskID, taskName, priority, dueDate);
                    else
                    {
                        Console.Write("Enter Position: ");
                        int position = Convert.ToInt32(Console.ReadLine());
                        taskList.AddAtPosition(position, taskID, taskName, priority, dueDate);
                    }
                    break;

                case 4:
                    Console.Write("Enter Task ID to remove: ");
                    int removeID = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveTask(removeID);
                    break;

                case 5:
                    taskList.ViewCurrentTask();
                    break;

                case 6:
                    taskList.DisplayTasks();
                    break;

                case 7:
                    Console.Write("Enter Priority to search: ");
                    int searchPriority = Convert.ToInt32(Console.ReadLine());
                    taskList.SearchByPriority(searchPriority);
                    break;

                case 8:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}