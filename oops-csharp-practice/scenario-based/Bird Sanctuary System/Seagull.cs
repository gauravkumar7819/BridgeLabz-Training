using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bird_Sanctuary_System
{
    internal class Seagull:Bird,ISwimmable,IFlyable
    {
		public void Swim()
		{
			Console.WriteLine(Name + " " + " is swiming");
		}
		public void Fly()
		{
			Console.WriteLine(Name + " " + " is flying");
		}
	}
}
