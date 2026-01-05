using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Application
{
    internal class Customer
    {
		public string CustomerName { get; set; }

		public void RentVehicle(IRentable vehicle, int days)
		{
			vehicle.CalculateRent(days);
			Console.WriteLine("Total Rent: " );
		}
	}
}

