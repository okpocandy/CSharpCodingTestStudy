using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Study
{
    internal class _21736
    {
        static int n;
        static int m;
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = nm[0];
            m = nm[1];
            char[,] graph = new char[n, m];
            int x = 0;
            int y = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    graph[i, j] = line[j];
                    if (line[j] == 'I')
                    {
                        y = i;
                        x = j;
                    }
                }
            }
            int ans = BFS(x, y, graph);
            if (ans == 0)
            {
                Console.WriteLine("TT");
            }
            else
            {
                Console.WriteLine(ans);
            }
        }

        static public int BFS(int x, int y, char[,] graph)
        {
            Queue<int[]> q = new Queue<int[]>();
            int[] dy = { 1, 0, -1, 0 };
            int[] dx = { 0, 1, 0, -1 };
            graph[y, x] = 'X';
            q.Enqueue(new int[] { y, x });
            int cnt = 0;
            while (q.Count > 0)
            {
                int[] node = q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int ny = node[0] + dy[i];
                    int nx = node[1] + dx[i];
                    if (ny < 0 || nx < 0 || ny >= n || nx >= m)
                        continue;
                    if (graph[ny, nx] == 'X')
                        continue;
                    else
                    {
                        if (graph[ny, nx] == 'P')
                            cnt++;
                        q.Enqueue(new int[] { ny, nx });
                        graph[ny, nx] = 'X';
                    }
                }
            }
            return cnt;
        }
    }
}
