using System;
class SumtoZero
{
    static void Main()
    {
        int inpValue = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
       while (inpValue!= 0)
        {
            sum += inpValue;
        
            Console.WriteLine("Enter a number");
            int p=Convert.ToInt32(Console.ReadLine());
            inpValue=p;}
            Console.WriteLine("The sum is:"+sum);


    }
}