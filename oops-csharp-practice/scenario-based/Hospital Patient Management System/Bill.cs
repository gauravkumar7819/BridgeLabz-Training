using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Management_System
{
    internal class Bill
    {
		public void GenerateBill(IPayable ip)
		{
			ip.CalculateBill();
		}

	}
}
