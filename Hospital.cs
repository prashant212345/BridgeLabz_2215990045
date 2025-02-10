using System;
using System.Collections.Generic;

// Abstract class Patient
abstract class Patient
{
    private int patientId;
    private string name;
    private int age;
    protected string diagnosis; // Protected to allow subclass access

    public int PatientId
    {
        get { return patientId; }
        set { patientId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Patient(int patientId, string name, int age, string diagnosis)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
        this.diagnosis = diagnosis;
    }

    public abstract double CalculateBill(); // Abstract method to be implemented

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

// Interface IMedicalRecord
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// InPatient class implementing IMedicalRecord
class InPatient : Patient, IMedicalRecord
{
    private double dailyCharge;
    private int numberOfDays;
    private List<string> medicalRecords = new List<string>();

    public InPatient(int patientId, string name, int age, string diagnosis, double dailyCharge, int numberOfDays)
        : base(patientId, name, age, diagnosis)
    {
        this.dailyCharge = dailyCharge;
        this.numberOfDays = numberOfDays;
    }

    public override double CalculateBill()
    {
        return dailyCharge * numberOfDays;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records for " + Name + ":");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine("- " + record);
        }
    }
}

// OutPatient class implementing IMedicalRecord
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;
    private List<string> medicalRecords = new List<string>();

    public OutPatient(int patientId, string name, int age, string diagnosis, double consultationFee)
        : base(patientId, name, age, diagnosis)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records for " + Name + ":");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine("- " + record);
        }
    }
}

// Main Class to Demonstrate Polymorphism
class Hospital
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>();

        InPatient inpatient1 = new InPatient(101, "Alice", 30, "Pneumonia", 2000, 5);
        OutPatient outpatient1 = new OutPatient(201, "Bob", 40, "Flu", 500);

        inpatient1.AddRecord("X-Ray Scan");
        inpatient1.AddRecord("Prescribed Antibiotics");

        outpatient1.AddRecord("General Checkup");
        outpatient1.AddRecord("Flu Medication");

        patients.Add(inpatient1);
        patients.Add(outpatient1);

        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();
            Console.WriteLine("Total Bill: " + patient.CalculateBill());

            IMedicalRecord medicalRecord = patient as IMedicalRecord;
            if (medicalRecord != null)
            {
                medicalRecord.ViewRecords();
            }

            Console.WriteLine("-------------------------");
        }
    }
}
