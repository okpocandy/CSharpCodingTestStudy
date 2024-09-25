using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.트리
{
    internal class _1240
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            List<(int, int)>[] graph = new List<(int, int)>[n + 1];
            
            for (int i = 0; i < n + 1; i++)
            {
                graph[i] = new List<(int, int)>();
            }
            for (int i = 0; i < n - 1; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[ints[0]].Add((ints[1], ints[2]));
                graph[ints[1]].Add((ints[0], ints[2]));
            }
            for(int i=0; i<m; i++)
            {
                int[] se = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] visited = new int[n + 1];
                BFS(se[0], se[1], visited, graph);
                Console.WriteLine(visited[se[1]]);
            }
        }

        static void BFS(int start, int end, int[] visited, List<(int, int)>[] graph)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            visited[start] = 0;
            while (q.Count > 0)
            {
                int node = q.Dequeue();
                foreach (var i in graph[node])
                {
                    if (visited[i.Item1] == 0)
                    {
                        visited[i.Item1] = visited[node] + i.Item2;
                        q.Enqueue(i.Item1);
                    }
                }
            }
        }
    }
}
