using System;

class CircularTour
{
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        int start = 0;
        int balance = 0;
        int deficit = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            balance += petrol[i] - distance[i];

            if (balance < 0)
            {
                deficit += balance;
                balance = 0;
                start = i + 1;
            }
        }

        return (balance + deficit >= 0) ? start : -1;
    }

    static void Main()
    {
        Console.Write("Enter number of petrol pumps: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] petrol = new int[n];
        int[] distance = new int[n];

        Console.WriteLine("Enter petrol values:");
        for (int i = 0; i < n; i++)
        {
            petrol[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter distance values:");
        for (int i = 0; i < n; i++)
        {
            distance[i] = Convert.ToInt32(Console.ReadLine());
        }

        int startPump = FindStartingPump(petrol, distance);

        if (startPump == -1)
            Console.WriteLine("No circular tour possible");
        else
            Console.WriteLine("Start at petrol pump index: " + startPump);
    }
}
