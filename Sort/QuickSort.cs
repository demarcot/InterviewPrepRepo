using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrepRepo
{
    public static class QuickSort
    {
        public static void Sort(int[] arr, int lIndex, int rIndex, bool verbose = true)
        {
            if(lIndex < rIndex)
            {
                int mid = Partition(arr, lIndex, rIndex);
                Sort(arr, lIndex, mid - 1);
                Sort(arr, mid + 1, rIndex);
            }
        }

        private static int Partition(int[] arr, int lIndex, int rIndex)
        {
            int pivot = arr[rIndex];
            int i = lIndex;

            for (int j = lIndex; j < rIndex; j++)
            {
                if (arr[j] < pivot)
                {
                    int t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                    i++;
                }
            }

            int t2 = arr[i];
            arr[i] = arr[rIndex];
            arr[rIndex] = t2;

            return i;
        }

        public static void RunQuickSort()
        {
            int[] arr = new int[] { 3, 7, 5, 1, 8 };
            Console.WriteLine("--- Original:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");

            QuickSort.Sort(arr, 0, arr.Length-1);

            Console.WriteLine("--- Final:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");
        }
    }
}
