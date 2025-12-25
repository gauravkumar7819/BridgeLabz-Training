using System;
class NumberofHandshakes
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int handshakes = CalculateHandshakes(n);
        Console.WriteLine("Number of Handshakes: " + handshakes);
    }
    public static int CalculateHandshakes(int n)
    {
        return n * (n - 1) / 2;
    }
}