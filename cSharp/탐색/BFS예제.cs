using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class BFS예제
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

            BFS(graph, 1, visited);

            
        }

        static void BFS(List<int>[] graph, int start, List<bool> visited )
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;
            while ( queue.Count > 0 )
            {
                int node = queue.Dequeue();
                Console.WriteLine(node);
                
                foreach(int i in graph[node])
                {
                    if (!visited[i])
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }    
                }
            }
        }
    }
}
