
using System;
class NaturalNumberWhile{   
    static void Main(){
        int inpNum=Convert.ToInt32(Console.ReadLine());
        if(inpNum >= 1){
            int sum=0;
            int count=1;
            while(count <= inpNum){
                sum += count;
                count++;
            }
            int formulaSum = inpNum * (inpNum + 1) / 2;
            Console.WriteLine("The sum using while loop is " + sum);
            Console.WriteLine("The sum using formula is " + formulaSum);
            if(sum == formulaSum){
                Console.WriteLine("Both computations are correct.");
            } else {
                Console.WriteLine("There is a discrepancy in the computations.");
            }
        }
        else{
            Console.WriteLine("The number " + inpNum + " is not a natural number");
        }
    }   
}
