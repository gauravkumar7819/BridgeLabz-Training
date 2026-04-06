using System;

class Vehicle
{
    public static double RegistrationFee = 500;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
    {
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }

    public void DisplayDetails()
    {
        if (this is Vehicle)
        {
            Console.WriteLine("Owner: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Registration Fee: " + RegistrationFee);
        }
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    static void Main()
    {
        Vehicle.UpdateRegistrationFee(600);

        Vehicle v1 = new Vehicle("Gaurav", "Car", "REG101");
        Vehicle v2 = new Vehicle("Anita", "Bike", "REG102");

        v1.DisplayDetails();
        Console.WriteLine();
        v2.DisplayDetails();
    }
}
