using Hospital_Patient_Management_System;

internal class OutPatient : Patient, IPayable
{ public int charge;
		public void CalculateBill()
		{
			Console.WriteLine(charge);
		}
	}
