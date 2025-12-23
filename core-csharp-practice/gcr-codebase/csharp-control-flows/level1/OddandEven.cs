
using System;
class OddandEven{
    static void Main(){
        int inpNum=Convert.ToInt32(Console.ReadLine());
        if(inpNum >= 1){
            for(int i=1;i<=inpNum;i++){
                if(i % 2 == 0){
                    Console.WriteLine(i + " is an even number");
                }
                else{
                    Console.WriteLine(i + " is an odd number");
                }
            }
        }
        else{
            Console.WriteLine("The number " + inpNum + " is not a natural number");
        }
    }   
}