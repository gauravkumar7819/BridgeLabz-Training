using System;
class BodyMassIndex2D
{
    static void Main()
    {
        Console.WriteLine("enter number of persons:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] personData = new int[n, 2]; // Column 0 for weight, Column 1 for height in cm
        double[] bmiA = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter weight (in kg) of person " + (i + 1) + ":");
            personData[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height (in cm) of person " + (i + 1) + ":");
            personData[i, 1] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            double heightInMeters = personData[i, 1] / 100.0;
            double bmi = personData[i, 0] / (heightInMeters * heightInMeters);
            bmiA[i] = bmi;
        }

        for (int i = 0; i < n; i++)
        {
            if (bmiA[i] < 18.5)
            {
                Console.WriteLine("Person " + (i + 1) + " is underweight.");
                Console.WriteLine("person bmi is " + bmiA[i]);
            }
            else if (bmiA[i] >= 18.5 && bmiA[i] < 24.9)
            {
                Console.WriteLine("Person " + (i + 1) + " has normal weight.");
                Console.WriteLine("person bmi is " + bmiA[i]);
            }
            else if (bmiA[i] >= 25 && bmiA[i] < 29.9)
            {
                Console.WriteLine("Person " + (i + 1) + " is overweight.");
                Console.WriteLine("person bmi is " + bmiA[i]);
            }
            else
            {
                Console.WriteLine("Person " + (i + 1) + " is obese.");
                Console.WriteLine("person bmi is " + bmiA[i]);
            }
        }
    }
}