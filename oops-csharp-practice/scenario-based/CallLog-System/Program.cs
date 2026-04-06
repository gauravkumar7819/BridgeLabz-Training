using CallLog_System;

namespace CallLog_System
{
	class Program
	{
		static void Main()
		{
			CallLogManager manager = new CallLogManager(10);

			CallLog cl = new CallLog("9876543210", "Network issue", DateTime.Now.AddHours(-3));
			manager.AddCallLog(cl);
			
			//manager.AddCallLog("9123456789", "Billing problem", DateTime.Now.AddHours(-2));
			//manager.AddCallLog("9988776655", "Network slow speed", DateTime.Now.AddHours(-1));
			//manager.AddCallLog("9000011111", "SIM not working", DateTime.Now);

			manager.SearchByKeyword("network");

			DateTime startTime = DateTime.Now.AddHours(-2);
			DateTime endTime = DateTime.Now;

			manager.FilterByTime(startTime, endTime);
		}
	}
}