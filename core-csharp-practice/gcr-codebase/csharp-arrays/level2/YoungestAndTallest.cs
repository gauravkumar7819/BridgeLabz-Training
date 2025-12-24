using System;

class YoungestAndTallest
{
    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i]=Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Enter height of " + names[i]);
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int yi = 0;
        int ti = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[yi])
                yi = i;
            if (heights[i] > heights[ti])
                ti = i;
        }

        Console.WriteLine(names[yi] + " is the youngest (age " + ages[yi] + ")");
        Console.WriteLine(names[ti] + " is the tallest (height " + heights[ti] + ")");}
}
