
using System;
class Bonus{        
    static void Main(){
        Console.WriteLine("Enter the Salary");
        double salary=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the years of service");
        int yearsOfService=Convert.ToInt32(Console.ReadLine());
        double bonus=0;
        if(yearsOfService>5){
            bonus=salary*0.05;
        }
        Console.WriteLine("The bonus amount is:"+bonus);
    }
}