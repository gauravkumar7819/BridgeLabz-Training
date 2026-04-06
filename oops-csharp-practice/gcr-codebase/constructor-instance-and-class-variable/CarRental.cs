using System;

class CarRental
{
    string customerName;
    string carModel;
    int rentalDays;
    int costPerDay;
    int totalCost;

    // Default constructor
    public CarRental()
    {
        customerName = "Customer";
        carModel = "Hatchback";
        rentalDays = 1;
        costPerDay = 1000;
        CalculateTotalCost();
    }

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        costPerDay = 1500;
        CalculateTotalCost();
    }

    // Method to calculate total cost
    void CalculateTotalCost()
    {
        totalCost = rentalDays * costPerDay;
    }

    public void Display()
    {
        Console.WriteLine("Customer: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Rental Days: " + rentalDays);
        Console.WriteLine("Total Cost: ₹" + totalCost);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CarRental r1 = new CarRental(); // default
        CarRental r2 = new CarRental("Rahul", "Sedan", 3); // parameterized

        r1.Display();
        r2.Display();
    }
}
