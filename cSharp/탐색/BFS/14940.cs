using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _14940
    {
        static int[] nm;
        static int n;
        static int m;
        static int[,] graph;
        static int[,] visited;

        static void Main(string[] args)
        {
            nm = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
            if (nm.Length < 2)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            n = nm[0];
            m = nm[1];
            graph = new int[n, m];
            visited = new int[n, m];

            int x = 0;
            int y = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()?.Split() ?? Array.Empty<string>();
                for (int j = 0; j < m; j++)
                {
                    graph[i, j] = int.Parse(line[j]);
                    if (graph[i, j] == 2)
                    {
                        y = i;
                        x = j;
                    }
                }
            }

            BFS(x, y);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // graph[i, j]가 1인데 방문하지 않은 경우 -1로 설정
                    if (graph[i, j] == 1 && visited[i, j] == 0)
                    {
                        sb.Append("-1 ");
                    }
                    else
                    {
                        sb.Append(visited[i, j] + " ");
                    }
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        static void BFS(int startX, int startY)
        {
            Queue<int[]> q = new Queue<int[]>();
            int[] dy = { 1, 0, -1, 0 };
            int[] dx = { 0, 1, 0, -1 };
            q.Enqueue(new int[] { startY, startX });
            visited[startY, startX] = 0;  // 시작점은 거리 0

            while (q.Count > 0)
            {
                int[] node = q.Dequeue();
                int nodeY = node[0];
                int nodeX = node[1];

                for (int i = 0; i < 4; i++)
                {
                    int ny = nodeY + dy[i];
                    int nx = nodeX + dx[i];
                    if (ny < 0 || nx < 0 || ny >= n || nx >= m)
                        continue;
                    if (graph[ny, nx] == 0)
                        continue;
                    if (graph[ny, nx] == 1 && visited[ny, nx] == 0)
                    {
                        q.Enqueue(new int[] { ny, nx });
                        visited[ny, nx] = visited[nodeY, nodeX] + 1;
                    }
                }
            }
        }
    }
}
