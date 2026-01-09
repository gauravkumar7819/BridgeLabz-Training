using System;
using System.Collections.Generic;

class MyHashMap
{
    private const int SIZE = 10;
    private List<KeyValuePair<int, int>>[] table;

    public MyHashMap()
    {
        table = new List<KeyValuePair<int, int>>[SIZE];
        for (int i = 0; i < SIZE; i++)
            table[i] = new List<KeyValuePair<int, int>>();
    }

    private int Hash(int key)
    {
        return key % SIZE;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);
        table[index].RemoveAll(p => p.Key == key);
        table[index].Add(new KeyValuePair<int, int>(key, value));
    }

    public int Get(int key)
    {
        int index = Hash(key);
        foreach (var pair in table[index])
            if (pair.Key == key)
                return pair.Value;
        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        table[index].RemoveAll(p => p.Key == key);
    }
}

class Program
{
    static void Main()
    {
        MyHashMap map = new MyHashMap();

        Console.Write("Enter number of entries: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            map.Put(key, value);
        }

        Console.Write("Enter key to get value: ");
        int searchKey = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Value: " + map.Get(searchKey));
    }
}
