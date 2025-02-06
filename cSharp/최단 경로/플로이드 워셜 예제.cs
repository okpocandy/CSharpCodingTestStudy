using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최단_경로
{
    internal class 플로이드_워셜_예제
    {
        static void Main(string[] args)
        {
            int INF = 987654321;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] graph = new int[n + 1, n + 1];
            for(int i=0; i<n+1; i++)
            {
                for(int j=0; j<n+1;j++)
                {
                    graph[i, j] = INF;
                }
            }
            for(int i=1; i<n+1;i++)
            {
                for(int j=1; j<n+1;j++)
                {
                    if (i == j)
                        graph[i, j] = 0;
                }
            }

            for(int i=0; i<m; i++)
            {
                int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = abc[0];
                int b = abc[1];
                int c = abc[2];
                graph[a, b] = c;
            }

            for(int k=1; k<n+1; k++)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                        graph[i, j] = Math.Min(graph[i, j], graph[i, k] + graph[k, j]);
                    }
                }
            }

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (graph[i, j] == INF)
                        Console.WriteLine("INFINITY");
                    else
                        Console.Write(graph[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

/*
 
4
7
1 2 4
1 4 6
2 1 3
2 3 7
3 1 5
3 4 4
4 3 2

출력:
0 4 8 6
3 0 7 9
5 9 0 4
7 11 2 0

 */