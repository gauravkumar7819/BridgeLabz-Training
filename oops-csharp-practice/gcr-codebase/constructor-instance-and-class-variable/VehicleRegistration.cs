using System;

class VehicleRegistration
{
    // Instance Variables
    string ownerName;
    string vehicleType;

    // Class Variable (static)
    static double registrationFee = 5000;

    // Constructor
    public VehicleRegistration(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance Method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
        Console.WriteLine();
    }

    // Class Method
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }

    // Main method
    static void Main()
    {
        // Creating vehicle objects
        VehicleRegistration v1 = new VehicleRegistration("Ravi Kumar", "Car");
        VehicleRegistration v2 = new VehicleRegistration("Anita Sharma", "Motorbike");

        Console.WriteLine("Before updating registration fee:\n");
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();

        // Update static registration fee
        VehicleRegistration.UpdateRegistrationFee(7500);

        Console.WriteLine("After updating registration fee:\n");
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
    }
}
