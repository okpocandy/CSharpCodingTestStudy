using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최단_경로
{
    internal class 전보
    {
        static void Main(string[] args)
        {
            const int INF = 987654321;
            int[] nmc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nmc[0];
            int m = nmc[1];
            int c = nmc[2];

            int[][] graph = new int[n+1][];
            for(int i=0; i<n+1; i++)
            {
                int[] ints = new int[n+1];
                Array.Fill(ints, INF);
                graph[i] = ints;
            }
            for(int i=0; i<m; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[ints[0]][ints[1]] = ints[2];
                graph[ints[1]][ints[0]] = ints[2];
            }

            for(int k=1; k<n+1; k++)
            {
                for(int a=1; a<n+1; a++)
                {
                    for(int b=1;  b<n+1; b++)
                    {
                        graph[a][b] = Math.Min(graph[a][b], graph[a][k] + graph[k][b]);
                    }
                }
            }

            int sum = 0;
            int dis = 0;
            foreach (var i in graph[c])
            {
                if (i != INF)
                {
                    sum++;
                    dis = Math.Max(dis, i);
                }
            }
            Console.WriteLine(sum-1 + " " + dis);
        }
    }
}

/*

3 2 1
1 2 4
1 3 2

*/