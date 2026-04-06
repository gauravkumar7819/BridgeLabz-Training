using System;
using System.Collections.Generic;
using System.Text;

namespace smart_home_automation
{
    internal class AC: Appliance, IControllable
    {
        public void TurnOn()
        {
            Console.WriteLine("The AC is turned on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("The AC is turned off.");
        }
	}
    
}
