using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _11403
    {
        static void Main(string[] args)
        {
            const int INF = 987654321;
            int n = int.Parse(Console.ReadLine());
            int[][] graph = new int[n + 1][];
            for (int i = 0; i < n + 1; i++)
            {
                int[] ints = new int[n + 1];
                Array.Fill(ints, INF);
                graph[i] = ints;
            }
            for (int i = 0; i < n; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0; j < n; j++)
                {
                    if (ab[j] == 1)
                    {
                        graph[i+1][j+1] = 1;
                    }
                }
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
            for (int a = 1; a < n + 1; a++)
            {
                for (int b = 1; b < n + 1; b++)
                {
                    if (graph[a][b] == INF)
                        Console.Write(0 + " ");
                    else
                        Console.Write(1 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
