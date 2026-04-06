using System;

class FestivalLuckyDraw 
{
    static void Main()
    {
        Random rnd = new Random();

        int visitor = 1;

        while (true)
        {
            Console.WriteLine("\nVisitor " + visitor + ": Press ENTER to draw lucky number (or type exit)");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            int luckyNumber = rnd.Next(0, 101); // 0 to 100

            Console.WriteLine("Lucky Number: " + luckyNumber);

            // Invalid number case
            if (luckyNumber == 0)
            {
                Console.WriteLine("Invalid number, chance skipped.");
                visitor++;
                continue;
            }

            // Gift condition
            if (luckyNumber % 3 == 0 && luckyNumber % 5 == 0)
            {
                Console.WriteLine("🎁 Congratulations! You won a gift!");
            }
            else
            {
                Console.WriteLine("No gift this time.");
            }

            visitor++;
        }

        Console.WriteLine("\nLucky Draw Ended 🎉");
    }
}
