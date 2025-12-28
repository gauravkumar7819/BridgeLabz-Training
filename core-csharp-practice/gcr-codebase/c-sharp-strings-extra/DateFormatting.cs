
using System;
class Datefrtting
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;

        string frt1 = currentDate.ToString("dd/MM/yyyy");
        string frt2 = currentDate.ToString("yyyy-MM-dd");
        string frt3 = currentDate.ToString("ddd, MMM dd, yyyy");

        Console.WriteLine("Current date in different frts:");
        Console.WriteLine("frt 1 (dd/MM/yyyy): " + frt1);
        Console.WriteLine("frt 2 (yyyy-MM-dd): " + frt2);
        Console.WriteLine("frt 3 (EEE, MMM dd, yyyy): " + frt3);
    }
}