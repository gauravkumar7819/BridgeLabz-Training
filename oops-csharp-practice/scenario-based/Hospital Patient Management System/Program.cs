using System;

namespace Hospital_Patient_Management_System
{
	internal class Program
	{
		static void Main(string[] args)
		{
			InPatient ip = new InPatient
			{
				Name = "Rahul",
				Age = 30,
				Disease = "Fever",
				NumberOfDays = 5,
				RoomChargePerDay = 2000
			};

			OutPatient op = new OutPatient
			{
				Name = "Amit",
				Age = 25,
				Disease = "Cold",
				charge = 500
			};

			Bill bill = new Bill();

			Console.WriteLine("----- InPatient Details -----");
			ip.DisplayInfo();
		
			bill.GenerateBill(ip);
			Console.WriteLine("\n----- OutPatient Details -----");
			op.DisplayInfo();
			bill.GenerateBill(op);
		}
	}
}
