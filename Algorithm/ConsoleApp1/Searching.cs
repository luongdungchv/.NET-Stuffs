using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Searching
    {
        public static void BinarySearch(int[] arr, int key)
        {
            void Search(int start, int end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == key)
                {
                    Console.WriteLine(mid);
                }
                if (key >= arr[mid] && mid < end) Search(mid + 1, end);
                if (key <= arr[mid] && mid > start) Search(start, mid - 1);
            }
            Array.Sort(arr);
            Search(0, arr.Length - 1);
        }
    }
}
