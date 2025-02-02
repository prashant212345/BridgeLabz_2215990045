using System;

class BankAccount
{
    // Public: Can be accessed from anywhere
    public int accountNumber;

    // Protected: Can be accessed in this class and derived classes
    protected string accountHolder;

    // Private: Can only be accessed within this class
    private double balance;

    // Constructor to initialize account details
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public Method: Get Balance
    public double GetBalance()
    {
        return balance;
    }

    // Public Method: Deposit Money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: ₹" + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Public Method: Withdraw Money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: ₹" + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    // Public Method: Display Account Details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: ₹" + balance);
        Console.WriteLine();
    }
}

// Derived Class: Demonstrating use of protected and public members
class SavingsAccount : BankAccount
{
    private double interestRate;

    // Constructor
    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        this.interestRate = interestRate;
    }

    // Method to Display Savings Account Details
    public void DisplaySavingsAccountDetails()
    {
        Console.WriteLine("Savings Account Details:");
        Console.WriteLine("Account Number: " + accountNumber); // Accessing public member
        Console.WriteLine("Account Holder: " + accountHolder); // Accessing protected member
        Console.WriteLine("Interest Rate: " + interestRate + "%");
        Console.WriteLine();
    }
}

// Main Method
class Program
{
    static void Main()
    {
        // Creating BankAccount Object
        BankAccount account1 = new BankAccount(10123456, "Rahul Sharma", 50000);

        // Displaying account details
        Console.WriteLine("Bank Account Details:");
        account1.DisplayAccountDetails();

        // Depositing money
        account1.Deposit(10000);
        Console.WriteLine("After Deposit:");
        account1.DisplayAccountDetails();

        // Withdrawing money
        account1.Withdraw(15000);
        Console.WriteLine("After Withdrawal:");
        account1.DisplayAccountDetails();

        // Creating SavingsAccount Object
        SavingsAccount savings1 = new SavingsAccount(10234567, "Anjali Verma", 75000, 4.5);

        // Display SavingsAccount details
        savings1.DisplaySavingsAccountDetails();
    }
}