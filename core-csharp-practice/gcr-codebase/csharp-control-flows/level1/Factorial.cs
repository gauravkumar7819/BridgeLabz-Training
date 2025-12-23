using System;
class Factorial{
static void Main(){
Console.WriteLine("Enter the Number");
int inpValue=Convert.ToInt32(Console.ReadLine());
int fact=1;
for(int i=1;i<inpValue+1;i++){
fact=fact*i;

}
Console.WriteLine(fact);
}

}