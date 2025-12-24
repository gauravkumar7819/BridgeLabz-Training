using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] marks = new int[n, 3];
        double[] percent = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));

            Console.Write("Physics: ");
            marks[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Chemistry: ");
            marks[i, 1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maths: ");
            marks[i, 2] = Convert.ToInt32(Console.ReadLine());

          
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
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
          Console.WriteLine((i + 1) + "\t" + marks[i, 0] + "\t" + marks[i, 1] + "\t" +
                  marks[i, 2] + "\t" + percent[i] + "\t" + grade[i]);

        }
    }
}
