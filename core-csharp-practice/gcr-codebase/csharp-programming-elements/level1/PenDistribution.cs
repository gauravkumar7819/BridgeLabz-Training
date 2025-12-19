
using System;
class PenDistribution
{
    static void Main()
    {
        int tPens = 14;
        int tStudents = 3;
        int pensPerStudent = tPens / tStudents;
        int remainingPens = tPens % tStudents;
        Console.WriteLine("The Pen Per Student is " + pensPerStudent + " and the remaining pen not distributed is " + remainingPens);
    }
}