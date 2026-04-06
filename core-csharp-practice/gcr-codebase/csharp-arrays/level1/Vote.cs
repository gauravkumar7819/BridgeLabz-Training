using System;
class Vote
{
    static void Main(string[] args)
    {
        int[] age=new int[10];
        for(int i=0;i<10;i++)
        {
            Console.WriteLine("Enter the age of person "+(i+1));
            age[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(  "Persons eligible to vote are:");
        for(int i=0;i<10;i++)
        {
            if(age[i]>=18)
            {
                Console.WriteLine("Person "+(i+1)+": "+age[i] +" is eligible to vote");

            }
            else
            {
                Console.WriteLine("Person "+(i+1)+": "+age[i] +" is not eligible to vote");
            }
        }
    }
}