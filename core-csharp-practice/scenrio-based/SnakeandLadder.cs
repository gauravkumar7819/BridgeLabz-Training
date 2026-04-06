using System;

class SnakeLadder
{
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Snake & Ladder Game (2 Players)");

        // Player names
        Console.Write("Enter Player 1 name: ");
        string player1 = Console.ReadLine();

        Console.Write("Enter Player 2 name: ");
        string player2 = Console.ReadLine();

        int pos1 = 0;
        int pos2 = 0;

        while (true)
        {
            // Player 1 Turn
            Console.WriteLine("\n" + player1 + " turn. Press Enter to roll dice");
            Console.ReadLine();

            int dice = RollDice();
            Console.WriteLine("Dice: " + dice);

            if (pos1 + dice <= 100)
            {
                pos1 = pos1 + dice;
                 
            }
            else
            {
                Console.WriteLine("Move skipped");
            }

            Console.WriteLine(player1 + " position: " + pos1);

            if (pos1 == 100)
            {
                Console.WriteLine(player1 + " WINS!");
                break;
            }

            // Player 2 Turn
            Console.WriteLine("\n" + player2 + " turn. Press Enter to roll dice");
            Console.ReadLine();

            dice = RollDice();
            Console.WriteLine("Dice: " + dice);

            if (pos2 + dice <= 100)
            {
                pos2 = pos2 + dice;
                pos2 = SnakeOrLadder(pos2);
            }
            else
            {
                Console.WriteLine("Move skipped");
            }

            Console.WriteLine(player2 + " position: " + pos2);

            if (pos2 == 100)
            {
                Console.WriteLine(player2 + " WINS!");
                break;
            }
        }

        Console.WriteLine("\nGame Over");
    }

    static int RollDice()
    {
        return random.Next(1, 7);
    }

    static int SnakeOrLadder(int pos)
    {
        if (pos == 6)  return 25;   // ladder
        if (pos == 11) return 40;   // ladder
        if (pos == 99) return 54;   // snake
        if (pos == 70) return 55;   // snake

        return pos;
    }
}
