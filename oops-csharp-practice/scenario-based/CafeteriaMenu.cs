using System;

class CafeteriaMenu
{
    string[] arr;

    CafeteriaMenu(string[] arr)
    {
        this.arr = arr;
    }

    public void DisplayItems()
    {
        Console.WriteLine("\n--- Cafeteria Menu ---");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine((i + 1) + " :- " + arr[i]);
        }
    }

    public void GetById(int idx)
    {
        if (idx < 1 || idx > 10)
        {
            Console.WriteLine("Invalid item number");
            return;
        }

        Console.WriteLine("\nSelected Item:");
        Console.WriteLine(idx + " :- " + arr[idx - 1]);
    }

    static void Main()
    {
        string[] arr1 = new string[10];

        Console.WriteLine("Enter the menu items:");
        for (int i = 0; i < 10; i++)
        {
            arr1[i] = Console.ReadLine();
        }

        CafeteriaMenu cm = new CafeteriaMenu(arr1);

        cm.DisplayItems();

        Console.Write("\nEnter item number to view: ");
        int idx = Convert.ToInt32(Console.ReadLine());

        cm.GetById(idx);
    }
}
