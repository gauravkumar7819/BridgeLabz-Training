using System;
class FactorialWhile{
static void Main(){ 
Console.WriteLine("Enter the Number");
int inpValue=Convert.ToInt32(Console.ReadLine());
int fact=1;
int i=1;
while(i<inpValue+1){
fact=fact*i;
i++;
}
Console.WriteLine(fact);
}

}