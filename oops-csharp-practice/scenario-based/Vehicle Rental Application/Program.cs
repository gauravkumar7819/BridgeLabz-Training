using System;
using Vehicle_Rental_Application;
class Program
{
	static void Main(string[] args)
	{
		Customer c = new Customer();
		c.CustomerName = "Rahul";

		Car car = new Car();
		car.Name = "Swift";
		car.VehicleID = 23;
		car.RatePerDay = 10;

		Console.WriteLine("Customer Name: " + c.CustomerName);
		Console.WriteLine("Car Name: " + car.Name);

		c.RentVehicle(car, 4);
	}
}