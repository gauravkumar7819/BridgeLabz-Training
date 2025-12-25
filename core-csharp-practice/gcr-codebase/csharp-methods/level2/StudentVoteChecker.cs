
using System;
class StudentVoteChecker
{
    static void Main()
    {
        int[] ages = new int[10];
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter the age of student " + (i + 1) + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < ages.Length; i++)
        {
            bool canVote = CanStudentVote(ages[i]);
            if (canVote)
            {
                Console.WriteLine("Student " + (i + 1) + " with age " + ages[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " with age " + ages[i] + " cannot vote.");
            }
        }
    }

    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }
        else if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}