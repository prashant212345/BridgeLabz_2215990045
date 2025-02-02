using System;

class Course{

	// Instance Variables (Specific to each course)
    private string courseName;
    private int duration;
	private double fee;
	
    // Class Variable (Shared among all courses)
	private static string instituteName = "Default Institute";

    // Constructor to initialize a course
	public Course(string courseName, int duration, double fee){
		this.courseName = courseName;
		this.duration = duration;
		this.fee = fee;		
	}
	
    // Instance Method: Display details of the course
	public void DisplayCourseDetails(){
		Console.WriteLine("Institute Name : "+instituteName);
		Console.WriteLine("Course Name : "+ courseName);
		Console.WriteLine("Duration : "+ duration +" years");
		Console.WriteLine("Fee : ₹"+fee);
		Console.WriteLine();
	}

    // Class Method: Update institute name (affects all courses)
	public static void UpdateInstituteName(string newInstituteName){
		instituteName = newInstituteName;
		Console.WriteLine("Institute Name Updated to : "+ instituteName);
	}
	
	static void Main(){
	    // Creating Course Objects
		Course course1 = new Course("B.Tech", 4, 200000);
		Course course2 = new Course("B.Com", 3, 150000);
		
		// Display details before updating institute name
		Console.WriteLine("Before Updating Institute Name");
		course1.DisplayCourseDetails();
		course2.DisplayCourseDetails();
		
		// Update institute name
        Course.UpdateInstituteName("GLA University");

        Console.WriteLine("\nAfter Updating Institute Name:");

        // Display course details after update
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
	}
	
}