using System;
class AveragePercent
{
    static void Main()
    {
        Console.WriteLine("Enter maths marks:");
        int maths = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Physics marks ");
        int phy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter chemistry marks:");
        int chem = Convert.ToInt32(Console.ReadLine());
        int total = maths + phy + chem;
        float average = total / 3.0f;
        float percent = total / 300.0f * 100;
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Percentage: " + percent + "%");
    }
}