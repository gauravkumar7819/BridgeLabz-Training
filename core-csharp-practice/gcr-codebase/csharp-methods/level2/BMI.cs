using System;

class BMI
{
    static void Main()
    {
        double[,] data = new double[10, 3];   // 0-weight, 1-height, 2-bmi
        string[] result = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight of person " + (i + 1) + " (kg): ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of person " + (i + 1) + " (cm): ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        CalculateBMI(data);
        result = GetBMIStatus(data);

        Console.WriteLine("\nNo\tWeight\tHeight\tBMI\tStatus");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                data[i, 0] + "\t" +
                data[i, 1] + "\t" +
                data[i, 2] + "\t" +
                result[i]
            );
        }
    }

    static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double h = data[i, 1] / 100;
            data[i, 2] = data[i, 0] / (h * h);
        }
    }

    static string[] GetBMIStatus(double[,] data)
    {
        string[] result = new string[10];

        for (int i = 0; i < 10; i++)
        {
            double bmi = data[i, 2];

            if (bmi < 18.5)
                result[i] = "Underweight";
            else if (bmi < 25)
                result[i] = "Normal";
            else if (bmi < 30)
                result[i] = "Overweight";
            else
                result[i] = "Obese";
        }

        return result;
    }
}
