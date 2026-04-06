using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_System
{
    internal class Duck:Bird,ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine(Name+" "+" is swiming");
        }
    }
}
