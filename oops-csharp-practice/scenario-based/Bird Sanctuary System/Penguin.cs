using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bird_Sanctuary_System
{
    internal class Penguin:Bird,ISwimmable
    {
		public void Swim()
		{
			Console.WriteLine(Name + " " + " is swiming");
		}
	}
}
