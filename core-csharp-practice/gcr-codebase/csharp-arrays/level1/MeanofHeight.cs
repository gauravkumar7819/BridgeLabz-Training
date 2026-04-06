using System;
class MeanofHeight
{
    static void Main(string[] args)
    {
        double[] height = new double[11];
        double sum = 0.0;
       Console.WriteLine("enter the heights of prayers in cm");
       for(int i=0;i<11;i++)
       {
        height[i]=Convert.ToDouble(Console.ReadLine());
        sum+=height[i];
       }
         double mean=sum/11;
            Console.WriteLine("Mean height of prayers is: "+mean+" cm");
    }
}