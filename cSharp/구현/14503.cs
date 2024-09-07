using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _14503
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] rcd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int r = rcd[0];
            int c = rcd[1];
            int d = rcd[2];
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = {-1, 0, 1, 0  };
            int[][] graph = new int[n][];
            int cnt = 1;
            for(int i=0; i<n;  i++)
            {
                graph[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            graph[r][c] = 2;
            while(true)
            {
                if (graph[r + 1][c] != 0 && graph[r - 1][c] != 0 && 
                    graph[r][c+1] != 0 && graph[r][c-1] != 0)
                {
                    if (graph[r - dy[d]][c - dx[d]] == 1)
                            break;
                    else
                    {
                        r = r - dy[d];
                        c = c - dx[d];
                    }
                }
                else
                {
                    d--;
                    if (d == -1)
                        d = 3;
                    if (graph[r + dy[d]][c+dx[d]] == 0)
                    {
                        r += dy[d];
                        c += dx[d];
                        graph[r][c] = 2;
                        cnt++;
                    }    
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
