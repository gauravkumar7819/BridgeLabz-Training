using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Application
{
	internal class Vehicle
	{
		protected int vehicleID;
		protected int ratePerDay;

		public int VehicleID
		{
			get { return vehicleID; }
			set { vehicleID = value; }
		}

		public int RatePerDay
		{
			get { return ratePerDay; }
			set { ratePerDay = value; }
		}

		public void CalculateRent()
		{
			Console.WriteLine(ratePerDay * 13);
		}
		public void DisplayVehicle()
		{
			Console.WriteLine("Vehicle ID: " + vehicleID);
			Console.WriteLine("Rate Per Day: " + ratePerDay);
		}
	}

}
