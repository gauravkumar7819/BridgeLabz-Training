using System;
    class BonusofEmployee
    {
static void Main(string[] args)
        {
          double[] salary=new double[10];
        double[] experi=new double[10];
		double[] bonus=new double[10];
        for (int i=0;i<10;i++)
        {
            Console.WriteLine("Enter the Salary of Employee "+(i+1));
            salary[i]=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Experience of Employee "+(i+1)+" in years");
            experi[i]=Convert.ToDouble(Console.ReadLine());
        }
        for(int i=0;i<10;i++)
        {
            if(experi[i]>5)
            {
                bonus[i]=salary[i]*0.05;
            }
            else
            {
                bonus[i]=0;
            }
        }
        Console.WriteLine("Bonus of Employees are:");
        for(int i=0;i<10;i++)
        {
            Console.WriteLine("Employee "+(i+1)+": "+bonus[i]);
		}


	}
	}

