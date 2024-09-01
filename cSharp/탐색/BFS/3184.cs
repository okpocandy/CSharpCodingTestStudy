using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _3184
    {
        static int[] dy = { 1, 0, -1, 0 };
        static int[] dx = { 0, 1, 0, -1 };
        static int n;
        static int m;
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = nm[0];
            m = nm[1];
            List<char[]> graph = new List<char[]>();
            int s = 0;
            int w = 0;
            for(int i=0; i<n; i++)
            {
                graph.Add(Console.ReadLine().ToArray());
            }
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    if (graph[i][j] != '#')
                    {
                        (int sp, int wp) = BFS(j, i, graph);
                        s += sp;
                        w += wp;
                            
                    }
                }
            }
            Console.WriteLine(s + " " + w);

        }

        static (int, int) BFS(int startX, int startY, List<char[]> graph)
        {
            Queue<(int, int)> q = new Queue<(int, int)> ();
            q.Enqueue((startY, startX));
            int sh = 0;
            int wo = 0;
            if (graph[startY][startX] == 'o')
                sh++;
            else if (graph[startY][startX] == 'v')
                wo++;
            graph[startY][startX] = '#';
            while (q.Count > 0)
            {
                (int y, int x) = q.Dequeue ();
                for(int i=0; i<4; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];
                    if (ny < 0 || nx < 0 || ny >= n || nx >= m)
                        continue;
                    if (graph[ny][nx] == '#')
                        continue;
                    else if (graph[ny][nx] == 'o')
                        sh++;
                    else if (graph[ny][nx] == 'v')
                        wo++;
                    graph[ny][nx] = '#';
                    q.Enqueue((ny, nx));
                }
                
            }
            if (wo == 0 && sh == 0)
                return (0,0);
            else if (wo >= sh)
                return (0, wo);
            else
            {
                return (sh, 0);
            }

        }
    }
}
