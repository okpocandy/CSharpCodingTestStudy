using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 개선된_다익스트라_예제
    {
        const int INF = 987654321;
        static int n = 0;
        static int[] distance;
        static List<int[]>[] graph;

        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = nm[0];
            int m = nm[1];

            int start = int.Parse(Console.ReadLine());
            graph = new List<int[]>[n + 1];
            for (int i = 0; i <= n; i++)
            {
                graph[i] = new List<int[]>();
            }
            distance = new int[n + 1];
            Array.Fill(distance, INF);

            for (int i = 0; i < m; i++)
            {
                int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[abc[0]].Add([abc[1], abc[2]]);
            }

            Dijkstra(start);

            for (int i = 0; i < n + 1; i++)
            {
                if (distance[i] == INF)
                    Console.WriteLine("INFINITY");
                else
                    Console.WriteLine(distance[i]);
            }


        }

        static void Dijkstra(int start)
        {
            var pq = new PriorityQueue<(int dist, int node), int>();
            pq.Enqueue((0, start), 0);
            distance[start] = 0;
            while(pq.Count > 0)
            {
                var(dist, now) = pq.Dequeue();
                if (distance[now] < dist)
                    continue;
                foreach( var i in graph[now])
                {
                    int cost = dist + i[1];
                    if(cost < distance[i[0]])
                    {
                        distance[i[0]] = cost;
                        pq.Enqueue((cost, i[0]), cost);
                    }
                }
            }
        }
    }
}

/*

6 11
1
1 2 2
1 3 5
1 4 1
2 3 3
2 4 2
3 2 3
3 6 5
4 3 3
4 5 1
5 3 1
5 6 2
 
 */
