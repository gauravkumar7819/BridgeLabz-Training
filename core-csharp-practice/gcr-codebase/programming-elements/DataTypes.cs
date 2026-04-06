using System;
class DataTypes
{
    static void Main()
    {
        // Integer data type
      int a=10;
	  Console.WriteLine("this is an Integer"  + a);
      // Character data type
      char b='A';
	  Console.WriteLine("this is a char" +b);
        // String data type
        string str="Hello BridgeLabz";
        Console.WriteLine("this is a string " + str);
	  //float data type
	  float f=2.3f;
	  
	  Console.WriteLine("this is float"+f);
	  // double data type
	  double d=234443.45;
	  Console.WriteLine("double "+d);
        // Boolean data type
        bool bl=true;
        Console.WriteLine("this is boolean " + bl);
        // long data type
        long l=1234567890;
        Console.WriteLine("this is long " + l);
        // byte data type
        byte by=255;
        Console.WriteLine("this is byte " + by);
        // short data type
        short sh=32767;
        Console.WriteLine("this is short " + sh);
       //type casting
         double num=12.34;
            int Num=(int)num; 
            Console.WriteLine("Casted double to int: " +Num);
            //implicit casting
            int intNum=100;
            double implicitCastedNum=intNum;
            Console.WriteLine("Implicitly Casted int to double: " + implicitCastedNum);
            //explicit casting
            double doubleNum=9.78;  
            int explicitCastedNum=(int)doubleNum;  
            Console.WriteLine("Explicitly Casted double to int: " + explicitCastedNum); 
    
	  
    }
}