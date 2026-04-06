using System;
class CheckNum
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        string result = CheckNumber(number);
        Console.WriteLine(result);
       
}
public static string CheckNumber(int number)
    {
        if (number > 0)
        {
            return "Positive";
        }
        else if (number < 0)
        {
            return "Negative";
        }
        else
        {
            return "Zero";
        }
    }
}