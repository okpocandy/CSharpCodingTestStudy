using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.탐색.DFS
{
    internal class _2583
    {
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };
        static int[,] graph;
        static int m, n;

        static void Main(string[] args)
        {
            int[] mnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            m = mnk[0];
            n = mnk[1];
            int k = mnk[2];
            graph = new int[m, n];

            for (int i = 0; i < k; i++)
            {
                int[] tmp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int sx = tmp[0];
                int sy = tmp[1];
                int ex = tmp[2];
                int ey = tmp[3];

                for (int j = sy; j < ey; j++)
                {
                    for (int l = sx; l < ex; l++)
                    {
                        graph[j, l] = 1;
                    }
                }
            }

            List<int> ans = new List<int>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (graph[i, j] == 0)
                    {
                        int area = DFS(j, i);
                        ans.Add(area);
                    }
                }
            }

            ans.Sort();
            Console.WriteLine(ans.Count);
            Console.WriteLine(string.Join(" ", ans));
        }

        static int DFS(int x, int y)
        {
            int cnt = 1;
            graph[y, x] = 1;  // 현재 위치를 방문 처리

            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx >= 0 && nx < n && ny >= 0 && ny < m && graph[ny, nx] == 0)
                {
                    cnt += DFS(nx, ny);
                }
            }

            return cnt;
        }
    }
}
