using System;

class Dividecho
{
    static void Main()
    {
        Console.Write("Enter chocolates: ");
        int cho = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter children : ");
        int ch = Convert.ToInt32(Console.ReadLine());

      FindDivision(cho, ch);

    }
    public static void FindDivision(int cho, int ch)
    {
        int cpc = cho / ch;
        int rc = cho % ch;

        Console.WriteLine("Each child will get " + cpc + " cho.");
        Console.WriteLine("Remaining cho: " + rc);
    }
}
