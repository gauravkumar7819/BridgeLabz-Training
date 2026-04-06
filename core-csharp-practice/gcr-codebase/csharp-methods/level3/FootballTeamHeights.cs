using System;

class FootballTeamHeights
{
    static void Main()
    {
        int[] h = GetHeights();

        int sum = 0;
        int small = h[0];
        int large = h[0];

        for (int i = 0; i < h.Length; i++)
        {
            sum = sum + h[i];

            if (h[i] < small)
                small = h[i];

            if (h[i] > large)
                large = h[i];
        }

        double avg = (double)sum / h.Length;

        Console.WriteLine("Mean Height: " + avg + " cms");
        Console.WriteLine("Shortest Height: " + small + " cms");
        Console.WriteLine("Tallest Height: " + large + " cms");
    }

    static int[] GetHeights()
    {
        Random r = new Random();
        int[] h = new int[11];

        for (int i = 0; i < 11; i++)
        {
            h[i] = r.Next(150, 251);
        }

        return h;
    }
}
