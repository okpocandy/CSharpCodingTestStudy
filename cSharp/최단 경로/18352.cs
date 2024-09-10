using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최단_경로
{
    internal class _18352
    {
        static void Main(string[] args)
        {
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = ints[0];
            int m = ints[1];
            int k = ints[2];
            int x = ints[3];
            StringBuilder sb = new StringBuilder();
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
            for(int i=0; i <m; i++)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[a[0]].Add(a[1]);
            }
            int[] dist = DijkstraAlgorithm(graph, x, n);
            for(int i=1; i<=n; i++)
            {
                if (dist[i] == k)
                    sb.AppendLine(i.ToString());
            }
            if (sb.Length > 0)
                Console.WriteLine(sb.ToString());
            else
                Console.WriteLine(-1);
        }
        static int[] DijkstraAlgorithm(Dictionary<int, List<int>> graph, int start, int n)
        {
            int[] dist = new int[n + 1];
            for (int i = 0; i <= n; i++) dist[i] = int.MaxValue;
            dist[start] = 0;

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            pq.Enqueue(start, 0);

            while (pq.Count > 0)
            {
                int node = pq.Dequeue();
                foreach (var edge in graph[node])
                {
                    int next = edge;
                    int newDist = dist[node] + 1;
                    if (newDist < dist[next])
                    {
                        dist[next] = newDist;
                        pq.Enqueue(next, newDist);
                    }
                }
            }

            return dist;
        }

    }
}
