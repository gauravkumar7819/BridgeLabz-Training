using System;

class GradeSystem
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] phy = new int[n];
        int[] chem = new int[n];
        int[] math = new int[n];
        double[] percent = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));

            Console.Write("Physics marks: ");
            phy[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Chemistry marks: ");
            chem[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maths marks: ");
            math[i] = Convert.ToInt32(Console.ReadLine());



            int total = phy[i] + chem[i] + math[i];
            percent[i] = (total / 300.0) * 100;

            if (percent[i] >= 80) grade[i] = 'A';
            else if (percent[i] >= 70) grade[i] = 'B';
            else if (percent[i] >= 60) grade[i] = 'C';
            else if (percent[i] >= 50) grade[i] = 'D';
            else if (percent[i] >= 40) grade[i] = 'E';
            else grade[i] = 'R';
        }

        Console.WriteLine("\nStu\tPhy\tChem\tMath\t%\tGrade");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine((i + 1) + "\t" + phy[i] + "\t" + chem[i] + "\t" +
                  math[i] + "\t" + percent[i] + "\t" + grade[i]);

        }
    }
}
