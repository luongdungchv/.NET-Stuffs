using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Algorithm
    {
        [Obsolete]
        public static void MergeOrderedList(List<List<int>> input) 
        {
            List<int> tmp = new List<int>();
            List<int> res = new List<int>();
            List<int> order = new List<int>();
            int total = 0;

            for(int i = 0; i < input.Count; i++)
            {
                tmp.Add(input[i][0]);
                order.Add(0);
                total += input[i].Count;
            }
            while(res.Count < total)
            {
                int a = tmp[0];
                int b = 0;
                for(int i = 1; i < tmp.Count; i++)
                {
                    if (tmp[i] < a)
                    {
                        a = tmp[i];
                        b = i;
                    }
                }
                res.Add(tmp[b]);
                tmp.RemoveAt(b);
                order[b]++;
                if (order[b] < input[b].Count)
                {
                    tmp.Insert(b, input[b][order[b]]);
                }
                else tmp.Insert(b, 999);
            }
            res.ForEach(n => Console.WriteLine(n));
        }
        public static void FindOptimalSolution(float[] objFunc, float[,] bindMatrix, float[] bindValue)
        {
            List<int> J = new List<int>();
            float[] x0 = new float[objFunc.Length];
            float[] deltaKlist = new float[objFunc.Length];

            for (int x = 0; x < bindMatrix.GetLength(1); x++)
            {
                int zeroCount = 0;
                int oneCount = 0;
                for (int y = 0; y < bindMatrix.GetLength(0); y++)
                {
                    if (bindMatrix[y, x] == 0) zeroCount++;
                    else if (bindMatrix[y, x] == 1) oneCount++;
                }
                if (oneCount == 1 && zeroCount == bindMatrix.GetLength(0) - 1) J.Add(x);
            }
            for(int i = 0; i < bindValue.Length; i++)
            {
                x0[J[i]] = bindValue[i];            
            }
            for (int x = 0; x < bindMatrix.GetLength(1); x++)
            {
                float deltaK = 0;
                for (int y = 0; y < bindMatrix.GetLength(0); y++)
                {
                    deltaK += bindMatrix[y, x] * objFunc[J[y]];
                }
                deltaK -= objFunc[x];
                deltaKlist[x] = deltaK;
            }

            float deltaKmax = deltaKlist[0];
            int dkIndex = 0;
            for(int i = 1; i < deltaKlist.Length; i++)
            {
                if (deltaKlist[i] > deltaKmax)
                {
                    deltaKmax = deltaKlist[i];
                    dkIndex = i;
                }
            }
            if (deltaKmax < 0) return;
            if (!SolutionCheck(bindMatrix, dkIndex)) return;

            var minTeta = float.MaxValue;
            var tMinindex = 0;
            for (int y = 0; y < bindMatrix.GetLength(0); y++)
            {
                var teta = (float)x0[J[y]] / (float)bindMatrix[y, dkIndex];
                if (teta < minTeta)
                {
                    minTeta = teta;
                    tMinindex = y;
                }
            }
            var turnValue = bindMatrix[tMinindex, dkIndex];
            if(J[tMinindex] != dkIndex)
            {
                x0[dkIndex] = x0[J[tMinindex]];
                x0[J[tMinindex]] = 0;
                J[tMinindex] = dkIndex;
            }


            x0[J[tMinindex]] /= turnValue;
            for (int x = 0; x < bindMatrix.GetLength(1); x++)
            {
                bindMatrix[tMinindex, x] /= turnValue;
            }
            for(int y = 0; y < bindMatrix.GetLength(0); y++)
            {
                if (y == tMinindex) continue;
                var val = bindMatrix[y, dkIndex];
                x0[J[y]] -= x0[J[tMinindex]] * val;
                for (int x = 0; x < bindMatrix.GetLength(1); x++)
                {
                    bindMatrix[y, x] -= bindMatrix[tMinindex, x] * val;
                }
            }
            for(int x = 0; x < bindMatrix.GetLength(0); x++)
            {
                for(int y = 0; y < bindMatrix.GetLength(1); y++)
                {
                    var s = "";
                    if (y == bindMatrix.GetLength(1) - 1) s = Environment.NewLine;
                    Console.Write($"{bindMatrix[x, y]} " + s);
                }
            }            
        }
        static bool SolutionCheck(float[,] mat, int i)
        {
            for (int y = 0; y < mat.GetLength(0); y++)
            {
                if (mat[y, i] > 0) return true;
            }
            return false;
        }
        public static void EnumerateBinary(int n)
        {
            int count = 0;

            void Enumerate(char[] current, int index)
            {
                current[index] = '1';
                
                if(index == n - 2)
                {
                    current[n - 1] = '1';
                    Console.WriteLine(new string(current));
                    current[n - 1] = '0';
                    Console.WriteLine(new string(current));
                    count += 2;
                    return;
                }
                count++;
                Console.WriteLine(new string(current));
                for (int i = index + 1; i < n; i++)
                {
                    var newStr = new char[n];
                    Array.Copy(current, newStr, n);
                    Enumerate(newStr, i);
                }
            }
            char[] s = new char[n];
            for(int i = 0; i < n; i++)
            {
                s[i] = '0';
            }
            for (int i = 0; i < n; i++)
            {
                char[] newStr = new char[n];
                Array.Copy(s, newStr, n);
                Enumerate(newStr, i);
            }
            Console.WriteLine(count);
        }
        public static void SolveKnapsack(int[,] input, int storage)
        {
            int maxVal = 0;
            int Solve(int index, int currentStorage, int currentVal)
            {
                int max = currentVal;
                Console.WriteLine($"{index} {currentStorage} {currentVal}");
                for(int x = index + 1; x < input.GetLength(0); x++)
                {
                    if (currentStorage + input[x, 0] > storage) continue;
                    var i = Solve(x, currentStorage + input[x,0], currentVal + input[x,1]);
                    if (i > max) max = i;
                }
                return max;
            }
            for (int x = 0; x < input.GetLength(0); x++)
            {
                var i = Solve(x, input[x, 0], input[x, 1]);
                if (i > maxVal) maxVal = i;
            }
            Console.Write(maxVal);
        }
        public static void SolveKnapsack2(int[,] input, int storage)
        {
            float maxVal = 0;
            void Solve(int index, int currentStorage, int currentVal)
            {
                int max = currentVal;
                var remainingStorage = storage - currentStorage;
                var g = index == input.GetLength(0) - 1 ? currentVal :
                    currentVal + (float)remainingStorage * (float)input[index + 1, 1] / (float)input[index + 1, 0];
                Console.WriteLine($"{index} {currentStorage} {currentVal} {g}");
                if (g > maxVal)
                {
                    maxVal = g;
                    for (int x = index + 1; x < input.GetLength(0); x++)
                    {
                        if (currentStorage + input[x, 0] > storage) continue;
                        Solve(x, currentStorage + input[x, 0], currentVal + input[x, 1]);
                    }
                }

                
            }
            for (int x = 0; x < input.GetLength(0); x++)
            {
                Solve(x, input[x, 0], input[x, 1]);
            }
            Console.Write(maxVal);
        }
        public static void SolveTourism(int[,] input)
        {
            var path = new int[input.GetLength(0)];
            var valList = new int[input.GetLength(0)];
            for (int i = 0; i < valList.Length; i++) valList[i] = int.MaxValue;
            int Solve(int x, int y, int val, int n, bool[] visited)
            {
                
                if (n == input.GetLength(1) - 1)
                {
                    Console.WriteLine($"{x} {y} {val} {input[0, x]}");
                    return val + input[0, x];
                }
                int min = int.MaxValue;
                int p = -1;
                visited[y] = true;
                for (int i = 0; i < input.GetLength(0); i++)
                {
                    if (input[i, x] < 0 || visited[i] == true) continue;
                    var newArr = new bool[visited.Length];
                    Array.Copy(visited, newArr, visited.Length);
                    var a = Solve(i, x, val + input[i, x], n + 1, newArr);
                    if (a < min) min = a;
                    if (a < valList[n + 1])
                    {
                        valList[n+1] = a;
                        path[n + 1] = i;
                    }
                }
                return min;
            }
            int minVal = int.MaxValue;
            
            for(int i = 1; i < input.GetLength(0); i++)
            {
                var v = Solve(i, 0, input[i, 0], 1, new bool[input.GetLength(0)]);
                if (v < minVal)
                {
                    minVal = v;
                    path[1] = i;
                }
            }
            //Console.Write(minVal);
            foreach(var i in path) Console.WriteLine(i);
            Console.WriteLine(minVal);
        }
        public static void InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int a = arr[i];
                int j = i - 1;
                while(j > -1 && arr[j] > a)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = a;
            }
            foreach (var i in arr) Console.WriteLine(i);
        }
        public static List<List<float>> SolveLPMethod(string[] input, int count)
        {
            List<string> Split(string origin)
            {
                string s = "";
                origin = origin.Trim();
                origin += " ";
                List<string> res = new List<string>();
                foreach(var i in origin)
                {
                    if(i == ' ' || i == ',')
                    {
                        res.Add(s);
                        s = "";
                        continue;
                    }
                    s += i.ToString();
                }
                return res;
            }
            List<List<float>> table = new List<List<float>>();
            foreach (var s in input)
            {
                var list = Split(s);
                List<float> numList = list.Select(n => float.Parse(n)).ToList();
                table.Add(numList);
            }
            int c = 0;
            bool found = false;
            while(c < count || count == -1 && !found)
            {
                found = SolveLP(table);
                c++;
            }
            return table;
        }
        public static bool SolveLP(List<List<float>> table)
        {
            
            //Find all delta k
            for (int i = 3; i < table[0].Count - 1; i++)
            {
                float value = 0;
                for (int j = 1; j < table.Count - 1; j++)
                {
                    value += table[j][i] * table[j][0];
                }
                value -= table[0][i];
                table[table.Count - 1][i] = value;
            }

            for (int i = 3; i < table[0].Count - 1; i++)
            {
                if (table[table.Count - 1][i] <= 0) continue;
                bool s = false;
                for (int j = 1; j < table.Count - 1; j++)
                {
                    if (table[j][i] > 0)
                    {
                        s = true;
                        break;
                    }
                }
                if (s) continue;
                Console.WriteLine("No Solution");
                PrintTable(table);
                return true;
            }

            //Find delta k max
            float maxVal = float.MinValue;
            int maxKIndex = 0;
            for (int i = 3; i < table[0].Count - 1; i++)
            {
                float value = table[table.Count - 1][i];
                if (value > maxVal)
                {
                    maxVal = value;
                    maxKIndex = i;
                }
            }
            if (maxVal <= 0)
            {
                Console.WriteLine("Solution Found");
                PrintTable(table);
                return true;
            }
            for (int j = 1; j < table.Count - 1; j++)
            {
                table[j][table[0].Count - 1] = table[j][2] / table[j][maxKIndex];
            }

            float minVal = float.MaxValue;
            int minTIndex = 0;
            for (int j = 1; j < table.Count - 1; j++)
            {
                float tVal = table[j][table[0].Count - 1];
                if (tVal < 0) continue;
                if (tVal < minVal)
                {
                    minVal = tVal;
                    minTIndex = j;
                }
            }
            PrintTable(table);

            //Find main element and divide the line by the main element
            float mainElement = table[minTIndex][maxKIndex];
            for (int i = 2; i < table[0].Count - 1; i++)
            {
                table[minTIndex][i] /= mainElement;
            }
            //Rotate other lines
            for (int j = 1; j < table.Count - 1; j++)
            {
                if (j == minTIndex) continue;
                float rotationElement = table[j][maxKIndex];
                for (int i = 2; i < table[0].Count - 1; i++)
                {
                    table[j][i] = table[j][i] - table[minTIndex][i] * rotationElement;
                }
            }
            table[minTIndex][0] = table[0][maxKIndex];
            table[minTIndex][1] = maxKIndex - 3 + 1;

            float fx = 0;
            for(int j = 1; j < table.Count - 1; j++)
            {
                fx += table[j][2] * table[j][0];
            }
            table[table.Count - 1][2] = fx;
            return false;
        }
        public static void PrintTable(List<List<float>> table)
        {
            int charCount(float input) 
            {
                return input.ToString().Length;
            }
            List<int> lengthList = new List<int>();
            for(int j = 0; j < table[0].Count; j++)
            {
                int maxVal = int.MinValue;
                for(int i = 0; i < table.Count; i++)
                {
                    float val = table[i][j];
                    int count = charCount(val);
                    if (count > maxVal) maxVal = count;
                }
                lengthList.Add(maxVal + 1);
            }
            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < table[0].Count; j++)
                {
                    var val = table[i][j];
                    var l = lengthList[j];
                    Console.Write(val);
                    
                    for (int a = 0; a < l - charCount(val) + 1; a++)
                        Console.Write(" ");
                    if (j == 2 || j == table[0].Count - 2) Console.Write("|");
                }
                Console.Write(Environment.NewLine);
                if(i == 0 || i == table.Count - 2)
                {
                    for(int a = 0; a < table[i].Count; a++)
                    {
                        Console.Write("----");
                    }
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);
        }
    }
    public class Dog
    {
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }
    public class Cat
    {
        public void Meow()
        {
            Console.WriteLine("meow");
        }
    }
}
