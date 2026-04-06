using System;
using System.Collections.Generic;
using System.Text;

namespace smart_home_automation
{
    internal class Light : Appliance, IControllable
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is turned on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("The light is turned off.");
		}
	}
}
