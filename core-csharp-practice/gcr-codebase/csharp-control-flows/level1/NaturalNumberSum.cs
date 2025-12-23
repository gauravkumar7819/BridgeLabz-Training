
using System;
class NaturalNumberSum{
    static void Main(){
        int inpNum=Convert.ToInt32(Console.ReadLine());
        if(inpNum >= 1){
            int sum = inpNum * (inpNum + 1) / 2;
            Console.WriteLine("The sum of " + inpNum + " natural numbers is " + sum);
        }
        else{
            Console.WriteLine("The number " + inpNum + " is not a natural number");
        }
    }   
}