using System;
using System.Collections.Generic;
using System.Text;

namespace smart_home_automation
{
    internal class Fan:Appliance, IControllable
	{
        public void TurnOn()
        {
            Console.WriteLine("The fan is turned on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("The fan is turned off.");
		}
	}
}
