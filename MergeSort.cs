using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrepRepo
{
    public static class MergeSort
    {
        public static int[] Sort(int[] arr, bool verbose = true)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];
            Array.Copy(arr, 0, left, 0, left.Length);
            Array.Copy(arr, mid, right, 0, right.Length);

            // Left half
            left = Sort(left);
            // Right half
            right = Sort(right);

            // Merge
            return Merge(left, right);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int[] arr = new int[left.Length+right.Length];

            // Merge
            int c = 0;
            int i;
            for(i = 0; i < left.Length; i++)
            {
                if(left[i]<right[i])
                {
                    arr[c] = left[i];
                    arr[c + 1] = right[i];
                } else
                {
                    arr[c] = right[i];
                    arr[c + 1] = left[i];
                }
                c += 2;
            }
            
            // Put any leftover in the array
            if(i < left.Length)
            {
                arr[c] = left[left.Length-1];
            } else if(i < right.Length)
            {
                arr[c] = right[right.Length - 1];
            }

            return arr;
        }

        public static void RunMergeSort()
        {
            int[] arr = new int[] { 3, 7, 5, 1, 8 };
            Console.WriteLine("--- Original:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");

            arr = MergeSort.Sort(arr);

            Console.WriteLine("--- Final:");
            Utilities.PrintArr(arr);
            Console.WriteLine("---");
        }
    }
}
