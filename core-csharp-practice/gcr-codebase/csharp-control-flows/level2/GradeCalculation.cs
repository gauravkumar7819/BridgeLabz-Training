using System;

class GradeCalculation
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));

            Console.Write("Enter Physics marks: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths marks: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            int total = physics + chemistry + maths;
            double percentage = (total / 300.0) * 100;

            char grade;

            if (percentage >= 80)
                grade = 'A';
            else if (percentage >= 70)
                grade = 'B';
            else if (percentage >= 60)
                grade = 'C';
            else if (percentage >= 50)
                grade = 'D';
            else if (percentage >= 40)
                grade = 'E';
            else
                grade = 'R';

            Console.WriteLine(
                "Marks: " + physics + ", " + chemistry + ", " + maths +
                " | Percentage: " + percentage.ToString("F2") +
                "% | Grade: " + grade
            );
        }
    }
}
