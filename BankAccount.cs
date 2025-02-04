using System;

class BankAccount{
	
    // Static variable shared across all accounts
	private static string bankName = "State Bank of India";
	private static int totalAccounts = 0;
	
    // Readonly variable (cannot be changed once assigned)
	public readonly int AccountNumber;
	public string AccountHolderName;
	public double Balance;
	
	// Constructor using 'this' keyword
	public BankAccount(int accountNumber, string accountHolderName, double initialBalance){
		this.AccountNumber = accountNumber;
		this.AccountHolderName = accountHolderName;
		this.Balance = initialBalance;
		totalAccounts++; // Increment Total Accounts
	}
	
    // Static method to display total accounts
	public static void GetTotalAccounts(){
		Console.WriteLine("Total Bank Accounts: " + totalAccounts);
	}
	
    // Method to display account details using 'is' operator
	public void DisplayAccountDetails(){
		if(this is BankAccount){
			Console.WriteLine("Bank Name: " + bankName);
			Console.WriteLine("Account Number: " + AccountNumber);
			Console.WriteLine("Account Holder: " + AccountHolderName);
			Console.WriteLine("Balance: " + Balance);
			Console.WriteLine();
		}
	}
	
	static void Main(){
		
        // Creating bank accounts
		BankAccount acc1 = new BankAccount(101, "Alice", 5000.25);
		BankAccount acc2 = new BankAccount(102, "Bob", 6521.25);
		
        // Display details
		acc1.DisplayAccountDetails();
		acc2.DisplayAccountDetails();
		
        // Display total accounts
		BankAccount.GetTotalAccounts();
	}
}