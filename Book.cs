using System;

class Book{

    // Static variable shared across all books
	private static string LibraryName = "Chapter House";
	
    // Readonly variable for ISBN (cannot be changed once assigned)
	public readonly int ISBN;
	public string Title;
	public string Author;
	
    // Constructor using 'this' keyword
	public Book(int isbn, string title, string author){
		this.ISBN = isbn;
		this.Title = title;
		this.Author = author;
	}
	
    // Static method to display library name
	public static void DisplayLibraryName(){
		Console.WriteLine("Display Library Name: "+ LibraryName);
	}
	
    // Method to display book details
	public void DisplayBookDetails(){
		if(this is Book){
			Console.WriteLine("Library Name: "+LibraryName);
			Console.WriteLine("ISBN: "+ISBN);
			Console.WriteLine("Title of the Book: "+Title);
			Console.WriteLine("Author of the Book: "+Author);
			Console.WriteLine();
		}
	}
	
	static void Main(){
		Book.DisplayLibraryName();
		
        // Creating book objects
		Book bk1 = new Book(101, "Alice's Adventures in Wonderland", "Lewis Carroll");
		Book bk2 = new Book(102, "The Adventures of Huckleberry Finn", "Mark Twain");
		
        // Display book details
		bk1.DisplayBookDetails();
		bk2.DisplayBookDetails();
	}
}