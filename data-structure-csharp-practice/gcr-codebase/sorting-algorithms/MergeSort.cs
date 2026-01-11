using System;

class MergeSort
{
    static void MergeSortFunc(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortFunc(arr, left, mid);
            MergeSortFunc(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[arr.Length];
        int i = left, j = mid + 1, k = left;

        while (i <= mid && j <= right)
            temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];

        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];

        for (int x = left; x <= right; x++)
            arr[x] = temp[x];
    }

    static void Main()
    {
        Console.Write("Enter number of books: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter price: ");
            prices[i] = int.Parse(Console.ReadLine());
        }

        MergeSortFunc(prices, 0, n - 1);

        Console.WriteLine("Sorted Book Prices:");
        foreach (int p in prices)
            Console.Write(p + " ");
    }
}
