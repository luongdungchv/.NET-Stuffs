using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Enumerate
    {
        public static void EnumerateCombination(int[] input, int n)
        {
            void Enumerate(int index, int level, int c, int[] arr)
            {
                arr[level] = input[index];
                if(c == 1)
                {
                    var s = "";
                    foreach (var i in arr)
                    {
                        s += i.ToString();
                    }
                    Console.WriteLine(s);
                    return;
                }
                c--;
                for(int i = index + 1; i <= input.Length - c; i++)
                {
                    Enumerate(i, level + 1, c, arr);
                }
            }
            for(int i = 0; i <= input.Length - n; i++)
            {
                Enumerate(i, 0, n, new int[n]);
            }
        }
        public static void EnumerateBinary(int n)
        {
            void Enumerate(int num, int index, int[] arr)
            {
                arr[index] = num;
                if(index == n - 1)
                {
                    var s = "";
                    foreach(var i in arr)
                    {
                        s += i.ToString();
                    }
                    Console.WriteLine(s);
                    return;
                }
                Enumerate(1, index + 1, arr);
                Enumerate(0, index + 1, arr);
            }
            Enumerate(1, 0, new int[n]);
            Enumerate(0, 0, new int[n]);
        }
        public static void EnumeratePermutation(int n)
        {
            void Enumerate(int num, int index, bool[] arr, int[] arr2)
            {
                arr2[index] = num;
                var newArr = new bool[n];
                Array.Copy(arr, newArr, n);
                if(index == n - 1)
                {
                    foreach(var i in arr2)
                    {
                        Console.Write(i);
                    }
                    Console.Write("\n");
                    return;
                }
                newArr[num] = true;
                for (int i = 0; i < n; i++)
                {
                    if (newArr[i] == true) continue;
                    Enumerate(i, index + 1, newArr, arr2);
                   
                }
            }
            for (int i = 0; i < n; i++)
            {
                Enumerate(i, 0, new bool[n], new int[n]);
            }
        }
        public static void EnumerateMysticSquare(int n)
        {
            var arr = new int[n * n];
            var mat = new int[n, n];
            for (int i = 0; i < n * n; i++)
            {
                arr[i] = i + 1;
            }
            void Enumerate(int x, int y, int val, int sum, int currentSum)
            {
                mat[x, y] = val;
                arr[val - 1] = 0;
                if(sum == 0)
                {
                    if(y == 2)
                    {
                        foreach(var i in arr)
                        {
                            if (i == 0) continue;
                            Enumerate(1, 0, i, currentSum + val, 0);
                        }
                    }
                    else
                    {
                        foreach (var i in arr)
                        {
                            if (i == 0) continue;
                            Enumerate(x, y + 1, i, 0, currentSum + val);
                        }
                    }
                }
                else
                {
                    if(y == 2)
                    {
                        if (currentSum + val != sum) return;
                        foreach (var i in arr)
                        {
                            if (i == 0) continue;
                            Enumerate(2, 0, i, sum, 0);
                        }
                    }
                }
            }
            
        }
    }
}
