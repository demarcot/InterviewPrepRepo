using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrepRepo
{
    public static class SelectionSort
    {
        public static void Sort(int[] arr, bool verbose = true)
        {
            for(int start = 0; start < arr.Length - 1; start++)
            {
                int minIndex = start;
                for (int i = start; i < arr.Length; i++)
                {
                    if(arr[i] < arr[minIndex])
                    {
                        minIndex = i;
                    }
                }

                int t = arr[minIndex];
                arr[minIndex] = arr[start];
                arr[start] = t;

                if(verbose)
                {
                    Utilities.PrintArr(arr);
                }
            }
        }

        public static void RunSelectionSort()
        {
            int[] arr = new int[] { 3, 7, 5, 1, 8 };
            Console.WriteLine("--- Original:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");

            SelectionSort.Sort(arr);

            Console.WriteLine("--- Final:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");
        }
    }
}
