using System;

class Patient
{
    public static string HospitalName = "City Hospital";
    private static int totalPatients = 0;

    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(string Name, int Age, string Ailment, int PatientID)
    {
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        this.PatientID = PatientID;
        totalPatients++;
    }

    public void DisplayDetails()
    {
        if (this is Patient)
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Patient ID: " + PatientID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
        }
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    static void Main()
    {
        Patient p1 = new Patient("Gaurav", 25, "Fever", 101);
        Patient p2 = new Patient("Anita", 30, "Cold", 102);

        p1.DisplayDetails();
        Console.WriteLine();
        p2.DisplayDetails();
        Console.WriteLine();

        Patient.GetTotalPatients();
    }
}
