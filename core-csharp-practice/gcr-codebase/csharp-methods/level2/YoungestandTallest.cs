using System;

class YoungestandTallest
{
    static void Main()
    {
        int[] age = new int[3];
        double[] height = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of friend " + (i + 1) + ": ");
            age[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height of friend " + (i + 1) + " (cm): ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        int young = FindYoungest(age);
        int tall = FindTallest(height);

        Console.WriteLine("Youngest friend is Friend " + (young + 1) + " and age is " + age[young]);
        Console.WriteLine("Tallest friend is Friend " + (tall + 1) + " and height is " + height[tall] + " cm");
    }

    static int FindYoungest(int[] age)
    {
        int pos = 0;

        for (int i = 1; i < age.Length; i++)
        {
            if (age[i] < age[pos])
            {
                pos = i;
            }
        }
        return pos;
    }

    static int FindTallest(double[] height)
    {
        int pos = 0;

        for (int i = 1; i < height.Length; i++)
        {
            if (height[i] > height[pos])
            {
                pos = i;
            }
        }
        return pos;
    }
}
