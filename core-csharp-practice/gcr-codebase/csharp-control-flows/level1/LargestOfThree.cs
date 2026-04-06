  
using System;
class LargestOfThree{   
    static void Main(){   
        int inpNum1=Convert.ToInt32(Console.ReadLine());
        int inpNum2=Convert.ToInt32(Console.ReadLine());
        int inpNum3=Convert.ToInt32(Console.ReadLine());

        bool isFirstLargest = (inpNum1 > inpNum2) && (inpNum1 > inpNum3);
        bool isSecondLargest = (inpNum2 > inpNum1) && (inpNum2 > inpNum3);
        bool isThirdLargest = (inpNum3 > inpNum1) && (inpNum3 > inpNum2);

        Console.WriteLine("Is the first number the largest? " + isFirstLargest);
        Console.WriteLine("Is the second number the largest? " + isSecondLargest);
        Console.WriteLine("Is the third number the largest? " + isThirdLargest);
    }   
}   