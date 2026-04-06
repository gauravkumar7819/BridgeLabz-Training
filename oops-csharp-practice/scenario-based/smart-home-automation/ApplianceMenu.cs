using System;
using smart_home_automation;
namespace smart_home_automation
{
	internal class ApplianceMenu
	{
		public void ChooseAppliance()
		{
			Console.WriteLine("Choose an appliance:");
			Console.WriteLine("1. Light");
			Console.WriteLine("2. Fan");
			Console.WriteLine("3. AC");

			string choice = Console.ReadLine();
			IControllable appliance = null;

			switch (choice)
			{
				case "1":
					appliance = new Light();
					break;

				case "2":
					appliance = new Fan();
					break;

				case "3":
					appliance = new AC();
					break;

				default:
					Console.WriteLine("Invalid choice");
					return;
			}

			// Cast to base class to set name
			Appliance app = (Appliance)appliance;

			Console.Write("Enter appliance name: ");
			app.ApplianceName = Console.ReadLine();

			Console.WriteLine("Selected: " + app);

			Console.WriteLine("1. ON");
			Console.WriteLine("2. OFF");

			string action = Console.ReadLine();
			if (action == "1")
				appliance.TurnOn();
			else if (action == "2")
				appliance.TurnOff();
		}
	}
}