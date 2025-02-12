using System;

class ProcessNode
{
    public int ProcessID;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public ProcessNode Next;

    public ProcessNode(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head = null;
    private ProcessNode tail = null;
    private int timeQuantum;

    public RoundRobinScheduler(int timeQuantum)
    {
        this.timeQuantum = timeQuantum;
    }

    // Add process at the end of the circular list
    public void AddProcess(int processID, int burstTime, int priority)
    {
        ProcessNode newProcess = new ProcessNode(processID, burstTime, priority);
        if (head == null)
        {
            head = tail = newProcess;
            tail.Next = head; // Make it circular
        }
        else
        {
            tail.Next = newProcess;
            newProcess.Next = head;
            tail = newProcess;
        }
        Console.WriteLine($"Process {processID} added successfully.");
    }

    // Remove a process by Process ID
    public void RemoveProcess(int processID)
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        ProcessNode current = head, prev = null;

        // Find the process to remove
        do
        {
            if (current.ProcessID == processID)
            {
                if (current == head && current == tail) // Only one node
                {
                    head = tail = null;
                }
                else if (current == head) // Head process
                {
                    tail.Next = head.Next;
                    head = head.Next;
                }
                else if (current == tail) // Tail process
                {
                    prev.Next = head;
                    tail = prev;
                }
                else // Middle process
                {
                    prev.Next = current.Next;
                }
                Console.WriteLine($"Process {processID} completed and removed.");
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != head);

        Console.WriteLine($"Process {processID} not found.");
    }

    // Simulate Round Robin scheduling
    public void SimulateScheduling()
    {
        if (head == null)
        {
            Console.WriteLine("No processes to schedule.");
            return;
        }

        int totalTime = 0, completedProcesses = 0;
        int totalWaitingTime = 0, totalTurnAroundTime = 0;

        Console.WriteLine("\nExecuting Round Robin Scheduling...");

        while (head != null)
        {
            ProcessNode current = head;

            do
            {
                if (current.RemainingTime > 0)
                {
                    int executionTime = Math.Min(timeQuantum, current.RemainingTime);
                    current.RemainingTime -= executionTime;
                    totalTime += executionTime;

                    Console.WriteLine($"Executing Process {current.ProcessID} for {executionTime} units. Remaining: {current.RemainingTime}");

                    if (current.RemainingTime == 0)
                    {
                        int turnAroundTime = totalTime;
                        int waitingTime = turnAroundTime - current.BurstTime;
                        totalWaitingTime += waitingTime;
                        totalTurnAroundTime += turnAroundTime;
                        completedProcesses++;
                        Console.WriteLine($"Process {current.ProcessID} completed. Turnaround Time: {turnAroundTime}, Waiting Time: {waitingTime}");
                        RemoveProcess(current.ProcessID);
                    }
                }

                current = current.Next;

            } while (current != head && head != null);

            DisplayProcesses();
        }

        if (completedProcesses > 0)
        {
            Console.WriteLine($"Average Waiting Time: {totalWaitingTime / (double)completedProcesses}");
            Console.WriteLine($"Average Turnaround Time: {totalTurnAroundTime / (double)completedProcesses}");
        }
    }

    // Display processes in the circular queue
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in queue.");
            return;
        }

        Console.WriteLine("\nCurrent Process Queue:");
        ProcessNode temp = head;
        do
        {
            Console.WriteLine($"ProcessID: {temp.ProcessID}, Burst Time: {temp.BurstTime}, Remaining Time: {temp.RemainingTime}, Priority: {temp.Priority}");
            temp = temp.Next;
        } while (temp != head);
    }
}

class RoundCPU
{
    static void Main()
    {
        Console.Write("Enter time quantum for Round Robin Scheduling: ");
        int timeQuantum = Convert.ToInt32(Console.ReadLine());

        RoundRobinScheduler scheduler = new RoundRobinScheduler(timeQuantum);

        while (true)
        {
            Console.WriteLine("\nRound Robin CPU Scheduling:");
            Console.WriteLine("1. Add Process");
            Console.WriteLine("2. Display Processes");
            Console.WriteLine("3. Start Scheduling");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Process ID: ");
                    int processID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Burst Time: ");
                    int burstTime = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Priority: ");
                    int priority = Convert.ToInt32(Console.ReadLine());
                    scheduler.AddProcess(processID, burstTime, priority);
                    break;

                case 2:
                    scheduler.DisplayProcesses();
                    break;

                case 3:
                    scheduler.SimulateScheduling();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
