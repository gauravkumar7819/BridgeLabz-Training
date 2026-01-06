using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bird_Sanctuary_System
{
    internal class Sparrow:Bird,IFlyable
    {
		public void Fly()
		{
			Console.WriteLine(Name + " " + " is fly");
		}
	}
}
