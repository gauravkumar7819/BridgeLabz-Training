using System;

class DivideChocolates
{
    static void Main()
    {
        Console.Write("Enter the num of chocolates: ");
        int numOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the num of children: ");
        int numOfChildren = Convert.ToInt32(Console.ReadLine());

        int chocolatesPerChild = numOfChocolates / numOfChildren;
        int remainingChocolates = numOfChocolates % numOfChildren;

        Console.WriteLine("Each child will get " + chocolatesPerChild + " chocolates.");
        Console.WriteLine("Remaining chocolates: " + remainingChocolates);
    }
}
