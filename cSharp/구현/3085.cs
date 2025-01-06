using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _3085
    {
        static List<char[]> graph;
        static int N;
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            graph = new List<char[]>();
            int ans = 0;
            for(int i=0; i<N; i++)
            {
                graph.Add(Console.ReadLine().ToCharArray());
            }
            for(int i=0; i<N; i++)
            {
                for(int j=0; j<N; j++)
                {
                    if(j+1<N)
                    {
                        SwapHor(i, j);
                        ans = Math.Max(ans, GetMaxCandy());
                        SwapHor(i, j);
                    }
                    if(i + 1<N)
                    {
                        SwapVer(i, j);
                        ans = Math.Max(ans, GetMaxCandy());
                        SwapVer(i, j);
                    }
                    
                    
                }
            }
            Console.WriteLine(ans);
        }

        static void SwapHor(int y, int x)
        {
            char tmp = graph[y][x];
            graph[y][x] = graph[y][x + 1];
            graph[y][x + 1] = tmp;
        }
        static void SwapVer(int y, int x)
        {
            char tmp = graph[y][x];
            graph[y][x] = graph[y+1][x];
            graph[y+1][x] = tmp;
        }

        static int GetMaxCandy()
        {
            int max = 0;

            // 행 검사
            for (int i = 0; i < N; i++)
            {
                int count = 1;
                for (int j = 1; j < N; j++)
                {
                    if (graph[i][j] == graph[i][j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        max = Math.Max(max, count);
                        count = 1;
                    }
                }
                max = Math.Max(max, count);
            }

            // 열 검사
            for (int j = 0; j < N; j++)
            {
                int count = 1;
                for (int i = 1; i < N; i++)
                {
                    if (graph[i][j] == graph[i - 1][j])
                    {
                        count++;
                    }
                    else
                    {
                        max = Math.Max(max, count);
                        count = 1;
                    }
                }
                max = Math.Max(max, count);
            }

            return max;
        }
    }
}
