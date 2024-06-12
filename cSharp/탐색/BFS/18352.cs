using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _18352
    {
        static void Main(string[] args)
        {
            int[] nmkx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nmkx[0];
            int m = nmkx[1];
            int k = nmkx[2];
            int x = nmkx[3];
            List<int>[] graph = new List<int>[n+1];
            for (int i = 0; i < n+1; i++)
                graph[i] = new List<int> { };
            for(int i=0; i<m; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[ints[0]].Add(ints[1]);
            }
            List<int> visited = Enumerable.Repeat(0, n+1).ToList();
            BFS(graph, 1, visited);
            int f = 0;
            for(int i=0; i<visited.Count; i++)
            {
                if (visited[i] == k)
                {
                    f = 1;
                    Console.WriteLine(i);
                }
                    
            }
            if (f == 0)
                Console.WriteLine(-1);
        }

        static void BFS(List<int>[] graph, int start, List<int> visited)
        {
            Queue<(int,int)> q = new Queue<(int,int)>();
            int cnt = 0;
            q.Enqueue((start, cnt));
            visited[start] = cnt;
            while (q.Count > 0)
            {
                (int node, int count) = q.Dequeue();
                foreach(int i in graph[node] )
                {
                    if (visited[i] == 0)
                    {
                        q.Enqueue((i, count+1));
                        visited[i] = count + 1;
                    }
                }
            }
        }
    }
}
