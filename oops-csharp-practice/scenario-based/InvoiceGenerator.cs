using System;

namespace bank_account
{
	internal class InvoiceGenerator
	{
		static void Main()
		{
			string ss = Console.ReadLine();

			string[] arr = ss.Split(',');

			int totalAmount = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				string[] arr2 = arr[i].Split('-');

				string amountStr = arr2[1].Replace("INR", "").Trim();

				int amount = Convert.ToInt32(amountStr);

				totalAmount = totalAmount + amount;
			}

			Console.WriteLine("Total Invoice Amount: " + totalAmount + " INR");
		}
	}
}
