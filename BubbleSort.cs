using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrepRepo
{
    public static class BubbleSort
    {

        public static void Sort(int[] arr, bool verbose = true)
        {
            for(int end = arr.Length; end > 1; end--)
            {
                for (int i = 0; i < end - 1; i++)
                {
                    int t;
                    if(arr[i] > arr[i+1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }

                if(verbose)
                {
                    Utilities.PrintArr(arr);
                }
            }
        }

        public static void RunBubbleSort()
        {
            int[] arr = new int[] { 3, 7, 5, 1, 8 };
            Console.WriteLine("--- Original:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");

            BubbleSort.Sort(arr);

            Console.WriteLine("--- Final:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");
        }
    }
}
