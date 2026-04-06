using System;

class TimeZones
{
    static void Main()
    {
        DateTimeOffset currentTime = DateTimeOffset.UtcNow;

        TimeZoneInfo GMT = TimeZoneInfo.Utc;
        TimeZoneInfo IST = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo PST = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        Console.WriteLine("GMT Time: " + TimeZoneInfo.ConvertTime(currentTime, GMT));
        Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(currentTime, IST));
        Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(currentTime, PST));
    }
}
