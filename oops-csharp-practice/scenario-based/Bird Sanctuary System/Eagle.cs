using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_System
{
    internal class Eagle:Bird,IFlyable
    {
		public void Fly()
		{
			Console.WriteLine(Name + " " + " is fly");
		}
	}
}
