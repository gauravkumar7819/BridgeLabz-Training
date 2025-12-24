using System;
class MultiplicationTable
{
    static void Main(string[] args)
    {
        int []table=new int[10];;
        Console.WriteLine("enter the number");
        int num=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<10;i++)
        {
            table[i]=num*(i+1);
        }
        Console.WriteLine("Multiplication Table of "+num+" is:");
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(num + " x " + (i + 1) + " = " + table[i]);
        }
        Console.WriteLine(string.Join(" ", table));


    }
}