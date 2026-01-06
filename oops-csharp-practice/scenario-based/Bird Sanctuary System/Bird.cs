using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_System
{
    internal class Bird
    {
    
       public string Name;
      public string Color;
        public void Eat()
        {
            Console.WriteLine(Name+" "+"is eating");
        } 
        public string ToString()
		{
            return Name +"  "+Color;
        }
    }
}
