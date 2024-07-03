using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1389
    {
        static void Main(string[] args)
        {
            const int INF = 987654321;
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[][] graph = new int[n + 1][];

            for(int i=0; i<n+1; i++)
            {
                int[] ints = new int[n + 1];
                Array.Fill(ints, INF);
                graph[i] = ints;
            }
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (i == j)
                        graph[i][j] = 0;
                }
            }
            for(int i=0; i<m; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[ab[0]][ab[1]] = 1;
                graph[ab[1]][ab[0]] = 1;
            }

            for (int k = 0; k < n + 1; k++)
            {
                for (int a = 0; a < n + 1; a++)
                {
                    for (int b = 0; b < n + 1; b++)
                    {
                        graph[a][b] = Math.Min(graph[a][b], graph[a][k] + graph[k][b]);
                    }
                }
            }



            int min_sum = 987654321;
            int ans = 1;
            for (int a = 1; a < n + 1; a++)
            {
                int tmp = graph[a][1..].Sum();
                if(tmp < min_sum)
                {
                    ans = a;
                    min_sum = tmp;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
