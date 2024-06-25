using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _2178
    {

        static int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        static int n = NM[0];
        static int m = NM[1];
        static int[,] graph = new int[n, m];
        static int[,] visited = new int[n, m];
        static void Main(string[] args)
        {

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < m; j++)
                {
                    graph[i, j] = (int)(line[j] - '0');
                }
            }

            Console.Write(BFS(0, 0));
        }
        static int BFS(int startX, int startY)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();
            int[] dy = { 1, 0, -1, 0 };
            int[] dx = { 0, 1, 0, -1 };
            visited[startY, startX] = 1;
            q.Enqueue((startY, startX));

            while (q.Count > 0)
            {
                (int y, int x) = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];
                    if (ny < 0 || nx < 0 || ny >= n || nx >= m)
                        continue;
                    if (graph[ny, nx] == 0)
                        continue;
                    if (graph[ny, nx] == 1)
                    {
                        q.Enqueue((ny,nx));
                        graph[ny, nx] = graph[y, x] + 1;
                    }
                }

            }

            return graph[n - 1, m - 1];

        }
    }
}
