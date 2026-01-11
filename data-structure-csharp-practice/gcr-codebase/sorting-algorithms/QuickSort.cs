using System;

class QuickSort
{
    static void QuickSortFunc(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int p = Partition(arr, low, high);
            QuickSortFunc(arr, low, p - 1);
            QuickSortFunc(arr, p + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }

    static void Main()
    {
        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter price: ");
            prices[i] = int.Parse(Console.ReadLine());
        }

        QuickSortFunc(prices, 0, n - 1);

        Console.WriteLine("Sorted Product Prices:");
        foreach (int p in prices)
            Console.Write(p + " ");
    }
}
