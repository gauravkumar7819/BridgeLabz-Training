using System;

namespace AadharSorter
{
    class AadharUtility : IAadharService
    {
        private long[] aadharNumbers = new long[20];
        private int count = 0;

        // Add Aadhar number
        public void AddAadhar()
        {
            if (count >= aadharNumbers.Length)
            {
                Console.WriteLine("List full!");
                return;
            }

            Console.Write("Enter 12-digit Aadhar number: ");
            long num = Convert.ToInt64(Console.ReadLine());

            aadharNumbers[count++] = num;
            Console.WriteLine("Aadhar added.");
        }

        // Display
        public void DisplayAadhar()
        {
            if (count == 0)
            {
                Console.WriteLine("No Aadhar numbers.");
                return;
            }

            Console.WriteLine("\nAadhar Numbers:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(aadharNumbers[i]);
            }
        }

        // Radix Sort (Ascending)
        public void SortAadhar()
        {
            if (count == 0)
            {
                Console.WriteLine("Nothing to sort.");
                return;
            }

            long max = GetMax();
            for (long exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(exp);
            }

            Console.WriteLine("Aadhar numbers sorted (Ascending).");
        }

        // Binary Search
        public void SearchAadhar()
        {
            if (count == 0)
            {
                Console.WriteLine("List empty.");
                return;
            }

            Console.Write("Enter Aadhar to search: ");
            long key = Convert.ToInt64(Console.ReadLine());

            int index = BinarySearch(key);

            if (index == -1)
                Console.WriteLine("Aadhar not found.");
            else
                Console.WriteLine("Aadhar found at position " + (index + 1));
        }

        // ---------- Helper Methods ----------

        private long GetMax()
        {
            long max = aadharNumbers[0];
            for (int i = 1; i < count; i++)
            {
                if (aadharNumbers[i] > max)
                    max = aadharNumbers[i];
            }
            return max;
        }

        // Stable counting sort (important for same prefix)
        private void CountingSort(long exp)
        {
            long[] output = new long[count];
            int[] freq = new int[10];

            for (int i = 0; i < count; i++)
            {
                int digit = (int)((aadharNumbers[i] / exp) % 10);
                freq[digit]++;
            }

            for (int i = 1; i < 10; i++)
                freq[i] += freq[i - 1];

            for (int i = count - 1; i >= 0; i--)
            {
                int digit = (int)((aadharNumbers[i] / exp) % 10);
                output[freq[digit] - 1] = aadharNumbers[i];
                freq[digit]--;
            }

            for (int i = 0; i < count; i++)
                aadharNumbers[i] = output[i];
        }

        private int BinarySearch(long key)
        {
            int low = 0, high = count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (aadharNumbers[mid] == key)
                    return mid;
                else if (aadharNumbers[mid] < key)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
    }
}
