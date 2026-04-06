using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Application
{
    internal class Bike:Vehicle,IRentable
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public void CalculateRent(int days)
		{
			Console.WriteLine(ratePerDay * days);
		}
	}
}
