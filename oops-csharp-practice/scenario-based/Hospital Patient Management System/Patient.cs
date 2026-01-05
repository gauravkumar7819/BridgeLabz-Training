using System;

namespace Hospital_Patient_Management_System
{
	internal class Patient
	{
		private string name;
		private int age;
		private string disease;
	
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Disease
		{
			get { return disease; }
			set { disease = value; }
		}

		public virtual void DisplayInfo()
		{
			Console.WriteLine("Patient Name: " + Name);
			Console.WriteLine("Age: " + Age);
			Console.WriteLine("Disease: " + Disease);
		}
	}
}
