using System;

class Patient{
	// Static variable shared among all patients
	public static string HospitalName = "Max Healthcare";
	public static int totalpatients = 0;
	
	// Readonly variable for unique patientid
	public readonly int PatientID;
	public string Name;
	public string Ailment;
	
	// Constructor using 'this' keyword
	public Patient(int id, string name, string ailment){
		this.PatientID = id;
		this.Name = name;
		this.Ailment = ailment;
		totalpatients++;
	}
	
	// Static method to show total patients
	public static void GetTotalPatients(){
		Console.WriteLine("Total Patients admitted: "+totalpatients);
	}
	
	// Method to display vehicle patients using 'is' operator
	public void DisplayPatientDetails(){
		if(this is Patient){
			Console.WriteLine("Id: "+PatientID);
			Console.WriteLine("Name: "+Name);
			Console.WriteLine("Ailment: "+Ailment);
			Console.WriteLine();
		}
	}
	
	static void Main(){
		Console.WriteLine(HospitalName);
		Console.WriteLine();
		
		// Creating patient objects
		Patient pt1 = new Patient(01, "Anita", "Fever");
		Patient pt2 = new Patient(02, "Rajesh", "Asthma");
		
		// Display patient details
		pt1.DisplayPatientDetails();
		pt2.DisplayPatientDetails();
	}
}