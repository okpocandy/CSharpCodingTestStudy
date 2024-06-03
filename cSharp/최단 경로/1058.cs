using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.최단_경로
{
    internal class _1058
    {
        static void Main(string[] args)
        {
            const int INF = 987654321;
            int n = int.Parse(Console.ReadLine());
            int[][] graph = new int[n + 1][];
            for(int i = 0; i < n+1; i++)
            {
                int[] ints = new int[n + 1];
                Array.Fill(ints, INF);
                graph[i] = ints;
            }
            for(int i=1; i<n+1; i++)
            {
                string input = Console.ReadLine();
                for(int j=0; j<n;  j++)
                {
                    if (input[j] == 'Y')
                        graph[i][j+1] = 1;
                }
            }

            for(int k=1; k<n+1; k++)
            {
                for(int a=1; a<n+1; a++)
                {
                    for(int b=1; b<n+1; b++)
                    {
                        if(a!= b)
                            graph[a][b] = Math.Min(graph[a][b], graph[a][k] + graph[k][b]);
                    }
                }
            }
            int max_index = 0;
            int max_friend = 0;

            for(int i=1; i< n+1; i++)
            {
                int count = 0;
                for(int j=1; j<n+1; j++)
                {
                    if (graph[i][j] == 2)
                        count++;
                    if (graph[i][j] == 1)
                    {
                        if (graph[j][i] == 1)
                            count++;
                    }
                }
                max_friend = Math.Max(max_friend, count);
                
            }
            Console.WriteLine(max_friend);
        }
    }
}
