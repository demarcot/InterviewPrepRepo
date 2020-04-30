using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrepRepo
{
    public static class Utilities
    {
        public static void PrintArr<T>(T[] arr)
        {
            string s = "";
            foreach (T t in arr)
            {
                s += t + " ";
            }
            Console.WriteLine(s);
        }

    }
}
