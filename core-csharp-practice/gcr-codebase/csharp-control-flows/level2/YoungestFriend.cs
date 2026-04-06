using System;
class YoungestFriend
{
    static void Main(string[] args)
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());

        if (amarAge < akbarAge && amarAge < anthonyAge)
        {
            Console.WriteLine("Amar is the youngest.");
        }
        else if (akbarAge < amarAge && akbarAge < anthonyAge)
        {
            Console.WriteLine("Akbar is the youngest.");
        }
        else if (anthonyAge < amarAge && anthonyAge < akbarAge)
        {
            Console.WriteLine("Anthony is the youngest.");
        }
        else
        {
            Console.WriteLine("There is a tie for the youngest age.");
        }

        Console.Write("Enter Amar's height in cm: ");
        int amarHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height in cm: ");
        int akbarHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height in cm: ");
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());

        if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
        {
            Console.WriteLine("Amar is the tallest.");
        }
        else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight)
        {
            Console.WriteLine("Akbar is the tallest.");
        }
        else if (anthonyHeight > amarHeight && anthonyHeight > akbarHeight)
        {
            Console.WriteLine("Anthony is the tallest.");
        }
        else
        {
            Console.WriteLine("There is a tie for the tallest height.");
        }
    }
}