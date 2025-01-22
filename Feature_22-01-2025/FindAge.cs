using System;
class FindAge{
	public static void Main(String []args){
		string name = "Harry";
		int yob = 2000;
		int curr = 2024;
		Console.WriteLine(name+"'s age in "+curr+" is "+ (curr - yob));
	}
}