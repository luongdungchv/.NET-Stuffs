using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Graph
    {
        
    }
    public class NonDirectionalGraph: Graph
    {
        public int vertices;
       

        int[,] matrix = null;

        public NonDirectionalGraph(int v)
        {
            vertices = v;
            matrix = new int[v, v];
        }
        public void PrintGraph()
        {
            var visited = new bool[vertices];
            void DFS(int n)
            {
                visited[n] = true;
                Console.WriteLine(n);
                for(int i = 0; i < vertices; i++)
                {
                    if(!visited[i] && matrix[n, i] == 1)
                    {
                        DFS(i);
                    } 
                }
            }
            DFS(0);
        }
        public int ShortestPath(int from, int to)
        {
            int minVal = int.MaxValue;
            int[] path = null;
            void Search(int v, int n, bool[] visited, ref bool p)
            {
                Console.WriteLine($"{v} {n}");
                if (v == to)
                {
                    //Console.WriteLine(v);
                    if (n < minVal)
                    {
                        minVal = n;
                        path = new int[n + 1];
                        p = true;
                    }
                    return;
                }
                
                visited[v] = true;
                var min = int.MaxValue;
                for (int i = 0; i < vertices; i++)
                {
                    var newArr = new bool[vertices];
                    Array.Copy(visited, newArr, vertices);
                    bool ispath = false;
                    if (!visited[i] && matrix[v, i] == 1)
                    {
                        Search(i, n + 1, newArr, ref ispath);
                        //if (a < min) min = a;
                        if (ispath) { path[n + 1] = i; p = true; }
                        if (i == to) break;
                    }
                }
            }
            //var res = Search(from, 0, new bool[vertices]);
            bool t = false;
            Search(from, 0, new bool[vertices], ref t);
            path[0] = from;
            foreach(var i in path)
            {
                Console.WriteLine(i);
            }
            return minVal;
        }
        public int ShortestPath2(int from, int to)
        {
            int minVal = 0;
            Queue<int> queue = new Queue<int>();
            Queue<int> index = new Queue<int>();
            Stack<int> valStack = new Stack<int>();
            Stack<int> indexStack = new Stack<int>();
            List<int> path2 = new List<int>();

            var path = new int[vertices];

            var visited = new bool[vertices];
            queue.Enqueue(from);
            index.Enqueue(0);
            
            while(queue.Count != 0)
            {
                var val = queue.Dequeue();
                var i = index.Dequeue();
                
                //Console.WriteLine(val);
                valStack.Push(val);
                indexStack.Push(i);
                bool canBreak = false;
                for(int j = 0; j < vertices; j++)
                {
                    if(!visited[j] && matrix[val, j] == 1)
                    {
                        path[j] = val;
                        visited[j] = true;
                        if(j == to)
                        {
                            canBreak = true;                           
                            break;
                        }
                        
                        queue.Enqueue(j);
                        index.Enqueue(i + 1);
                    }
                }
                if (canBreak) break;
            }
            //var res = Search(from, 0, new bool[vertices]);
            //path2.ForEach(n => Console.WriteLine(n));
            path[from] = -1;
            var pathIndex = to;
            while(pathIndex >= 0)
            {
                path2.Insert(0, pathIndex);
                minVal++;
                pathIndex = path[pathIndex];
            }
            foreach(var i in path2)
            {
                Console.WriteLine(i);
            }
            return minVal - 1;
        }

        public int[,] SampleData()
        {
            vertices = 5;
            int[,] mat =
            {
                {0,1,1, 0,0},
                {1,0,1,1,0 },
                {1,1,0,1,1 },
                {0,1,1,0,0 },
                {0,0,1,0,0 }
            };
            matrix = mat;
            return mat;
        }
    }
    public class DirectionalGraph: Graph
    {

    }
    public class GraphNode
    {

    }
}
