using System;
class DivisiblebyFive{
static void Main(){
	int inpValue=Convert.ToInt32(Console.ReadLine());
    bool isDivisible = (inpValue % 5) == 0;
	Console.WriteLine("is this number is divisible by 5:"+isDivisible);
	
}}