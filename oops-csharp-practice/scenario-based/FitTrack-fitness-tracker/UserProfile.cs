using System;
using System.Collections.Generic;
using System.Text;

namespace FitTrack_fitness_tracker
{
    internal class UserProfile
    {
        private string userName;
        private int age;
        private double weight;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
		}
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public override string ToString()
        {
            return "Name:"+userName+" "+ "Age:"+Age+" "+"Weight:"+" "+Weight;
		}
	}
}
