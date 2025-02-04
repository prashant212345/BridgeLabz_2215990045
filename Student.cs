using System;

class Student{
	
	private static string UniversityName = "GLA University";
	private static int totalStudents = 0;
	
	public readonly int RollN;
	public string Name;
	public string Grade;
	
	public Student(int rollno, string name, string grade){
		this.RollN = rollno;
		this.Name = name;
		this.Grade = grade;
		totalStudents++;
	}
	
	public static void DisplayTotalStudents(){
		Console.WriteLine("Total Students: "+totalStudents);
	}
	
	public void displayStudentDetails(){
		if(this is Student){
			Console.WriteLine("Roll Number: "+RollN);
			Console.WriteLine("Name: "+Name);
			Console.WriteLine("Grade: "+Grade);
			Console.WriteLine();
		}
	}
	
	static void Main(){
		Console.WriteLine(UniversityName);
	
		Student st1 = new Student(1, "Prash", "O");
		Student st2 = new Student(2, "Tarun", "A+");
		
		st1.displayStudentDetails();
		st2.displayStudentDetails();
	}
}