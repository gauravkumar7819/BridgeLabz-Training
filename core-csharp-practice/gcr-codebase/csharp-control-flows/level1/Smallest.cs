using System;
class Smallest{
static void Main(){
	int inpNum1=Convert.ToInt32(Console.ReadLine());
		int inpNum2=Convert.ToInt32(Console.ReadLine());

	int inpNum3=Convert.ToInt32(Console.ReadLine());
 int small = (inpNum1 < inpNum2)? (inpNum1 < inpNum3 ? inpNum1 : inpNum3) 
                        : (inpNum2 < inpNum3 ? inpNum2 : inpNum3);

	Console.WriteLine(small);

	

}
}