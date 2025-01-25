using System;
class Voting{
	static void Main(){
		// Define an array to store the ages of 10 students
		int[] studentAges = new int[10];
		Console.WriteLine("Enter the age for 10 Students : ");
		
		// Loop to take user input for the ages
		for(int i=0; i<studentAges.Length; i++){
			Console.Write("Enter age for student "+(i+1)+": ");
			studentAges[i] = int.Parse(Console.ReadLine());
			
			// Check if the age is a negative number
            if (studentAges[i] < 0){
				Console.WriteLine("An Invalid age.");
            }
		}
		
		
		// Loop to check Voting Eligiblity
		for(int i=0; i<studentAges.Length; i++){
			if(studentAges[i] >= 18){
				Console.WriteLine("The student with the age "+studentAges[i]+" can vote.");
			}else{
				Console.WriteLine("The student with the age "+studentAges[i]+" cannot vote.");
			}
		}
	}
}