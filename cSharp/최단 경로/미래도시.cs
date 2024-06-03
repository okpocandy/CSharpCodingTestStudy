using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최단_경로
{
    internal class 미래도시
    {
        static void Main(string[] args)
        {
            const int INF = 987654321;
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[][] graph = new int[n+1][];

            for(int i=0; i<n+1; i++)
            {
                int[] ints = new int[n + 1];
                Array.Fill(ints, INF);
                graph[i] = ints;
            }
            
            for(int i=0; i<m; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[ab[0]][ab[1]] = 1;
                graph[ab[1]][ab[0]] = 1;
            }
            int[] xk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            for(int k=1; k<n+1; k++)
            {
                for(int a=1; a<n+1; a++)
                {
                    for(int b=1; b<n+1; b++)
                    {
                        graph[a][b] = Math.Min(graph[a][b], graph[a][k] + graph[k][b]);
                    }
                }
            }
            if (graph[1][xk[1]] == INF || graph[xk[1]][xk[0]] == INF)
                Console.WriteLine(-1);
            else
                Console.WriteLine(graph[1][xk[1]] + graph[xk[1]][xk[0]]);
        }
    }
}

/*

5 7
1 2
1 3
1 4
2 4
3 4
3 5
4 5
4 5


4 2
1 3
2 4
3 4


 */