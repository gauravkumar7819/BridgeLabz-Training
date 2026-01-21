using System;
using System.Collections.Generic;

namespace EduResults
{
    class ResultUtility : IResultService
    {
        private List<List<Student>> districtLists = new List<List<Student>>();
        private List<Student> finalRankList = new List<Student>();

        // Add sorted district list
        public void AddDistrictList()
        {
            Console.Write("Enter number of students in district: ");
            int n = int.Parse(Console.ReadLine());
             Console.Write("Enter District Name: ");
                string districtName = Console.ReadLine();

            List<Student> district = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Student {i + 1} Name: ");
                string name = Console.ReadLine();

               

                Console.Write("Enter Score: ");
                int score = int.Parse(Console.ReadLine());

                district.Add(new Student(name, districtName, score));
            }

            // Sort district list individually (ascending or descending, here descending)
            MergeSort(district, 0, district.Count - 1);
            districtLists.Add(district);

            Console.WriteLine("District list added and sorted.");
        }

        // Merge all district lists into finalRankList
        public void GenerateFinalRankList()
        {
            finalRankList.Clear();

            foreach (var district in districtLists)
            {
                finalRankList = Merge(finalRankList, district);
            }

            Console.WriteLine("Final state-wise rank list generated!");
        }

        // Display final rank list
        public void DisplayRankList()
        {
            if (finalRankList.Count == 0)
            {
                Console.WriteLine("Rank list not generated yet.");
                return;
            }

            Console.WriteLine("\n=== Final Rank List ===");
            int rank = 1;
            foreach (var student in finalRankList)
            {
                Console.WriteLine($"{rank}. {student}");
                rank++;
            }
        }

        // ---------- Merge Sort Logic ----------

        private void MergeSort(List<Student> arr, int left, int right)
        {
            if (left >= right) return;

            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            MergeLists(arr, left, mid, right);
        }

        private void MergeLists(List<Student> arr, int left, int mid, int right)
        {
            List<Student> temp = new List<Student>();
            int i = left, j = mid + 1;

            while (i <= mid && j <= right)
            {
                // Descending by score, stable
                if (arr[i].Score >= arr[j].Score)
                {
                    temp.Add(arr[i]);
                    i++;
                }
                else
                {
                    temp.Add(arr[j]);
                    j++;
                }
            }

            while (i <= mid)
            {
                temp.Add(arr[i]);
                i++;
            }

            while (j <= right)
            {
                temp.Add(arr[j]);
                j++;
            }

            for (int k = 0; k < temp.Count; k++)
            {
                arr[left + k] = temp[k];
            }
        }

        // Merge two sorted lists (for final merge)
        private List<Student> Merge(List<Student> list1, List<Student> list2)
        {
            List<Student> merged = new List<Student>();
            int i = 0, j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i].Score >= list2[j].Score) // descending
                {
                    merged.Add(list1[i]);
                    i++;
                }
                else
                {
                    merged.Add(list2[j]);
                    j++;
                }
            }

            while (i < list1.Count) merged.Add(list1[i++]);
            while (j < list2.Count) merged.Add(list2[j++]);

            return merged;
        }
    }
}
