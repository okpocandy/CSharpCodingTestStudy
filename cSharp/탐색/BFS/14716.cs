using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _14716
    {
        static int m;
        static int n;
        static void Main(string[] args)
        {
            int[] mn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            m = mn[0];
            n = mn[1];
            List<int[]> graph = new List<int[]>();
            for (int i = 0; i < m; i++)
            {
                graph.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            }
            int cnt = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (graph[i][j] == 1)
                    {
                        BFS(j, i, graph);
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }

        static void BFS(int startX, int startY, List<int[]> graph)
        {
            Queue<int[]> q = new Queue<int[]>();
            int[] dy = { 1, 0, -1, 0, 1, -1, 1, -1 };
            int[] dx = { 0, 1, 0, -1, 1, 1, -1, -1 };
            graph[startY][startX] = 0;
            q.Enqueue(new int[] { startY, startX }); // 여기 수정
            while (q.Count > 0)
            {
                int[] node = q.Dequeue();
                for (int i = 0; i < 8; i++)
                {
                    int ny = node[0] + dy[i];
                    int nx = node[1] + dx[i];
                    if (ny < 0 || nx < 0 || ny >= m || nx >= n)
                        continue;
                    if (graph[ny][nx] == 0)
                        continue;
                    if (graph[ny][nx] == 1)
                    {
                        q.Enqueue(new int[] { ny, nx }); // 여기 수정
                        graph[ny][nx] = 0;
                    }
                }
            }
        }
    }
}
