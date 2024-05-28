using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class DFS예제
    {
        static void Main(string[] args)
        {
            List<int>[] graph =
            {
                new List<int> { },
                new List<int> { 2, 3, 8 },
                new List<int> { 1, 7 },
                new List<int> { 1, 4, 5 },
                new List<int> { 3, 5 },
                new List<int> { 3, 4 },
                new List<int> { 7 },
                new List<int> { 2 ,6, 8 },
                new List<int> { 1, 7 }
            };

            List<bool> visited = Enumerable.Repeat(false, 10).ToList();

            DFS(graph, 1, visited); 
        }

        static void DFS(List<int>[]graph , int node,  List<bool> visited)
        {
            visited[node] = true;
            Console.Write($"{node} ");
            foreach(var i in graph[node])
            {
                if (!visited[i])
                    DFS(graph, i, visited);
            }
        }
    }
}
