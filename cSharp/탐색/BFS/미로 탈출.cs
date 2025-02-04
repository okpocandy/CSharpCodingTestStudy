using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class 미로_탈출
    {
        static int n;
        static int m;
        static int[,] graph;
        static int[] dx;
        static int[] dy;
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = nm[0];
            m = nm[1];
            dy = new int[4]{ -1, 1, 0, 0};
            dx = new int[4] { 0, 0, -1, 1 };

            graph = new int[n, m];
            for(int i=0; i<n; i++)
            {
                char[] ints = Console.ReadLine().ToCharArray();
                for(int j=0; j<m; j++)
                {
                    graph[i, j] = ints[j] - '0';
                }
            }

            Console.WriteLine(BFS(0, 0));
            Console.WriteLine();
        }

        static int BFS(int y, int x)
        {
            int dis = 0;
            Queue<(int y, int x)> q = new Queue<(int y, int x)> ();
            q.Enqueue((y, x));
            while(q.Count > 0)
            {
                (int sy, int sx) = q.Dequeue();
                for(int i=0; i<4; i++)
                {
                    int ny = sy + dy[i];
                    int nx = sx + dx[i];
                    if (nx < 0 || ny < 0 || nx >= m || ny >= n)
                        continue;
                    if (graph[ny, nx] == 0)
                        continue;
                    if (graph[ny, nx] == 1)
                    {
                        graph[ny, nx] = graph[sy, sx] + 1;
                        q.Enqueue((ny, nx));
                    }
                }
            }
            return graph[n - 1, m - 1];
        }
    }
}

/*
 
입력:
5 6
101010
111111
000001
111111
111111
 
 
 
 
 
 */