using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrepRepo
{
    public static class InsertionSort
    {
        public static void Sort(int[] arr, bool verbose = true)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] < arr[i-1])
                {
                    for (int j = i; j > 0 && arr[j] < arr[j-1]; j--)
                    {
                        int t = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = t;
                    }

                    if(verbose)
                    {
                        Utilities.PrintArr(arr);
                    }
                }
            }
        }

        public static void RunInsertionSort()
        {
            int[] arr = new int[] { 3, 7, 5, 1, 8 };
            Console.WriteLine("--- Original:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");

            InsertionSort.Sort(arr);

            Console.WriteLine("--- Final:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");
        }
    }
}
