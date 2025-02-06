using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최단_경로
{
    internal class 미래_도시
    {
        static void Main(string[] args)
        {
            int INF = 987654321;
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[,] graph = new int[n + 1, n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    graph[i, j] = INF;
                }
            }
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i == j)
                        graph[i, j] = 0;
                }
            }

            for (int i = 0; i < m; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = ab[0];
                int b = ab[1];
                int c = 1;
                graph[a, b] = c;
                graph[b, a] = c;
            }
            int[] xk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int x = xk[0];
            int e = xk[1];

            for (int k = 1; k < n + 1; k++)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                        graph[i, j] = Math.Min(graph[i, j], graph[i, k] + graph[k, j]);
                    }
                }
            }
            int dis = 0;
            dis = graph[1, e] + graph[e, x];
            if (dis >= INF)
                Console.WriteLine(1);
            else
                Console.WriteLine(dis);
        }
    }
}

/*
 
입력 1:
5 7
1 2
1 3
1 4
2 4
3 4
3 5
4 5
4 5
 
출력 1:
3

입력 2:
4 2
1 3
2 4
3 4

출력 2:
-1

 */