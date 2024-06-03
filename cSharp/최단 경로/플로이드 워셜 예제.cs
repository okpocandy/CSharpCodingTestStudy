using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최단_경로
{
    internal class 플로이드_워셜_예제
    {
        const int INF= 987654321;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[][] graph = new int[n + 1][];
            for (int i=0; i<graph.Length; i++)
            {
                int[] ints = new int[n + 1];
                Array.Fill(ints, INF);
                graph[i] = ints;
            }
            for(int i=0; i<n+1; i++)
            {
                for(int j=0; j < n+1; j++)
                {
                    if (i == j)
                        graph[i][j] = 0;
                }
            }

            for(int i=0; i<m; i++)
            {
                int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[abc[0]][abc[1]] = abc[2];
            }

            for (int k=0; k<n+1; k++)
            {
                for(int a=0; a<n+1; a++)
                {
                    for(int b=0; b<n+1; b++)
                    {
                        graph[a][b] = Math.Min(graph[a][b], graph[a][k] + graph[k][b]);
                    }
                }
            }
            
            for( int a=1; a<n+1;a++)
            {
                for(int b=1;b<n+1;b++)
                {
                    if (graph[a][b] == INF)
                        Console.Write("INFINITY" + " ");
                    else
                        Console.Write(graph[a][b] + " ");
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


*/