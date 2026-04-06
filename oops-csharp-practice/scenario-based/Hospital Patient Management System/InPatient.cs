using Hospital_Patient_Management_System;

internal class InPatient : Patient, IPayable
{
	public int NumberOfDays;
	public int RoomChargePerDay;

	public void CalculateBill()
	{
		Console.WriteLine(NumberOfDays * RoomChargePerDay);
	}

	

}
