using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _18405
    {
        static int[] dx;
        static int[] dy;
        static int n;
        static int k;
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = nk[0];
            k = nk[1];
            dx = new int[]{ 1, 0, -1, 0 };
            dy = new int[] { 0, 1, 0, -1 };
            int[,] graph = new int[n, n];
            Queue<(int y, int x, int cnt)> q = new Queue<(int y, int x, int cnt)>();
            PriorityQueue<(int y, int x), int> pq = new PriorityQueue<(int y, int x), int>();
            for(int i=0; i<n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0; j<n; j++)
                {
                    graph[i, j] = ints[j];
                    if (ints[j] != 0)
                        pq.Enqueue((i, j), ints[j]);

                }
            }
            while(pq.Count > 0)
            {
                (int a, int b) = pq.Dequeue();
                q.Enqueue((a, b, 0));
            }
            int[] sxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int s = sxy[0];
            int x = sxy[1];
            int y = sxy[2];
            BFS(graph, q, s);
            Console.WriteLine(graph[x-1, y-1]); 
        }

        static void BFS(int[,] graph, Queue<(int, int, int)> q, int s)
        {
            while(q.Count > 0)
            {
                (int y, int x, int cnt) = q.Dequeue();
                if(cnt >= s)
                    continue;
                
                for(int i=0; i<4; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];
                    if (ny < 0 || nx < 0 || nx >= n || ny >= n)
                        continue;
                    if (graph[ny, nx] == 0)
                    {
                        graph[ny, nx] = graph[y, x];
                        q.Enqueue((ny, nx, cnt+1));
                    }
                    
                }
                
            }
        }
        

    }
}
