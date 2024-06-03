using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 간단한_다익스트라_예제
    {
        const int INF = 987654321;
        static int n = 0;
        static int[] visited;
        static int[] distance;
        static List<int[]>[] graph;

        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = nm[0];
            int m = nm[1];

            int start = int.Parse(Console.ReadLine());
            graph = new List<int[]>[n+1];
            for (int i = 0; i <= n; i++)
            {
                graph[i] = new List<int[]>();
            }
            visited = new int[n + 1];
            distance = new int[n + 1];
            Array.Fill(distance, INF);

            for (int i = 0; i < m; i++)
            {
                int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[abc[0]].Add([abc[1], abc[2]]);
            }

            Dijkstra(start);

            for(int i=0; i<n+1; i++)
            {
                if (distance[i] == INF)
                    Console.WriteLine("INFINITY");
                else
                    Console.WriteLine(distance[i]);
            }


        }
        static int GetSmallestNode()
        {
            int minValue = INF;
            int index = 0;
            for(int i=1; i< n; i++)
            {
                if (distance[i] < minValue && visited[i] == 0)
                {
                    minValue = distance[i];
                    index = i;
                }
            }
            return index;
        }

        static void Dijkstra(int start)
        {
            distance[start] = 0;
            visited[start] = 1;
            foreach(var j in graph[start])
            {
                distance[j[0]] = j[1];
            }
            for (int i=0; i<n-1; i++)
            {
                int now = GetSmallestNode();
                visited[now] = 1;
                foreach(var j in graph[now])
                {
                    int cost = distance[now] + j[1];
                    if(cost < distance[j[0]])
                        distance[j[0]] = cost;
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
