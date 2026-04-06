using System;

class TemperatureAnalyzer
{
    const int DAYS = 7;
    const int HOURS = 24;

    static void Main()
    {
        float[,] temp = new float[DAYS, HOURS];
        bool isDataEntered = false;

        while (true)
        {
            Console.WriteLine("\n---- Temperature Analyzer Menu ----");
            Console.WriteLine("1. Enter Temperature Data");
            Console.WriteLine("2. Find Hottest Day");
            Console.WriteLine("3. Find Coldest Day");
            Console.WriteLine("4. Find Average Temperature");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    EnterTemperatures(temp);
                    isDataEntered = true;
                    break;

                case 2:
                    if (CheckData(isDataEntered))
                        Console.WriteLine("Hottest Day: Day " + FindHottestDay(temp));
                    break;

                case 3:
                    if (CheckData(isDataEntered))
                        Console.WriteLine("Coldest Day: Day " + FindColdestDay(temp));
                    break;

                case 4:
                    if (CheckData(isDataEntered))
                        Console.WriteLine("Average Temperature: " + FindAverageTemp(temp));
                    break;

                case 5:
                    Console.WriteLine("Exiting Program...");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }

    static void EnterTemperatures(float[,] temp)
    {
        for (int day = 0; day < DAYS; day++)
        {
            Console.WriteLine("Enter temperatures for Day " + (day + 1));
            for (int hour = 0; hour < HOURS; hour++)
            {
                temp[day, hour] = Convert.ToInt64(Console.ReadLine());
            }
        }
    }

    static bool CheckData(bool status)
    {
        if (!status)
        {
            Console.WriteLine("Please enter temperature data first!");
            return false;
        }
        return true;
    }

    static int FindHottestDay(float[,] temp)
    {
        int hottestDay = 0;
        float max = temp[0, 0];

        for (int day = 0; day < DAYS; day++)
        {
            for (int hour = 0; hour < HOURS; hour++)
            {
                if (temp[day, hour] > max)
                {
                    max = temp[day, hour];
                    hottestDay = day;
                }
            }
        }
        return hottestDay + 1;
    }

    static int FindColdestDay(float[,] temp)
    {
        int coldestDay = 0;
        float min = temp[0, 0];

        for (int day = 0; day < DAYS; day++)
        {
            for (int hour = 0; hour < HOURS; hour++)
            {
                if (temp[day, hour] < min)
                {
                    min = temp[day, hour];
                    coldestDay = day;
                }
            }
        }
        return coldestDay + 1;
    }

    static float FindAverageTemp(float[,] temp)
    {
        float sum = 0;
        int count = 0;

        for (int day = 0; day < DAYS; day++)
        {
            for (int hour = 0; hour < HOURS; hour++)
            {
                sum += temp[day, hour];
                count++;
            }
        }
        return sum / count;
    }
}
