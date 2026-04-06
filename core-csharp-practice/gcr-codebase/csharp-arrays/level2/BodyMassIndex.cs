using System;
class BodyMassIndex
{
    static void Main()
    {
        Console.WriteLine("enter number of persons:");
        int n=Convert.ToInt32(Console.ReadLine());
        int []weight= new int[n];
        double []height= new double[n];
        double []bmiA= new double[n];
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Enter weight (in kg) of person " + (i + 1) + ":");
            weight[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height (in meters) of person " + (i + 1) + ":");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            double bmi = weight[i] / (height[i] * height[i]);
            bmiA[i]=bmi;
        }

        for (int i = 0; i < n; i++)

        {
            if(bmiA[i]<18.5)
            {
                Console.WriteLine("Person " + (i + 1) + " is underweight.");
                Console.WriteLine("person bmi is "+bmiA[i]);
            }
            else if(bmiA[i]>=18.5 && bmiA[i]<24.9)
            {
                Console.WriteLine("Person " + (i + 1) + " has normal weight.");
                                Console.WriteLine("person bmi is "+bmiA[i]);

            }
            else if(bmiA[i]>=25 && bmiA[i]<29.9)
            {
                Console.WriteLine("Person " + (i + 1) + " is overweight.");
                                Console.WriteLine("person bmi is "+bmiA[i]);

            }
            else
            {
                Console.WriteLine("Person " + (i + 1) + " is obese.");
                                Console.WriteLine("person bmi is "+bmiA[i]);
            }
        }
    }
}