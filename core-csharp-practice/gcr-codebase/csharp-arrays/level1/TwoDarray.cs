using System;
class arr
{
        static void Main(string[] args)
        { int [,] arr = new int[3, 3];
          int[] arr2 = new int[9];
          int k = 0;

          Console.WriteLine("Enter elements for a 2D array (3 rows and 3 columns):");
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  arr[i, j] = Convert.ToInt32(Console.ReadLine());
              }
          }

          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  arr2[k++] = arr[i, j];
              }
          }

          Console.WriteLine("Elements in the single dimension array:");
          foreach (int i in arr2)
          {
              Console.Write(i + " ");
          }
            

        }
}