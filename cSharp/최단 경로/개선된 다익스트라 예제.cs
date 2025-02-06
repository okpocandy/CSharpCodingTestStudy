using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최단_경로
{
    internal class 개선된_다익스트라_예제
    {
        static int[] dis;
        static List<(int, int)>[] graph;
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int INF = 987654321;
            int st= int.Parse(Console.ReadLine());
            graph = new List<(int, int)>[n + 1];
            for (int i = 0; i <= n; i++)
            {
                graph[i] = new List<(int, int)>();
            }
            dis = new int[n + 1];
            Array.Fill(dis, INF);
            for(int i=0; i<m; i++)
            {
                int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[abc[0]].Add((abc[1], abc[2]));
            }
            dijkstra(st);

            for(int i=1; i<n+1; i++)
            {
                if (dis[i] == INF)
                    Console.WriteLine("INFINITY");
                else
                    Console.WriteLine(dis[i]);  
            }
        }

        static void dijkstra(int start)
        {
            PriorityQueue<(int, int), int> q = new PriorityQueue<(int, int), int>();
            dis[start] = 0;
            q.Enqueue((0, start), 0);
            while(q.Count > 0)
            {
                (int dist, int now) = q.Dequeue();
                if (dis[now] < dist)
                    continue;
                foreach(var i in graph[now])
                {
                    int cost = dist + i.Item2;
                    if(cost < dis[i.Item1])
                    {
                        dis[i.Item1] = cost;
                        q.Enqueue((cost, i.Item1), cost);
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

출력:
0
2
3
1
2
4
 
 */