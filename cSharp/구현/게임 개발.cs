using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 게임_개발
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];  //세로
            int m = nm[1];  //가로
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sy = ints[0];
            int sx = ints[1];
            int dir = ints[2];
            int[][] visited = new int[n][];
            int[][] graph = new int[n][];

            int[] dy = new int[4] { -1, 0, 1, 0 };
            int[] dx = new int[4] { 0, 1, 0, -1 };

            for(int i=0; i<n; i++)
            {
                int[] tmps = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[i] = tmps;
                visited[i] = new int[m];
            }
            bool t4 = true;
            int ans = 1;
            while(true)
            {
                visited[sy][sx] = 1;
                t4 = true;
                for(int i=0; i<4; i++)
                {
                    dir = Tl(dir);
                    int ny = sy + dy[dir];
                    int nx = sx + dx[dir];
                    if (visited[ny][nx] == 0 && graph[ny][nx] == 0)
                    {
                        sy = ny;
                        sx = nx;
                        
                        ans++;
                        t4 = false;
                        break;
                    }
                }
                if(t4)
                {
                    int ny = sy - dy[dir];
                    int nx = sx - dx[dir];
                    if (graph[ny][nx] == 0)
                    {
                        sy = ny;
                        sx = nx;
                    }
                    else
                        break;
                }

            }
            Console.WriteLine(ans);

        }
        static int Tl(int dir)
        {
            dir--;
            if (dir == -1)
                dir = 3;
            return dir;
        }
    }
}

/*

입력:
4 4
1 1 0
1 1 1 1
1 0 0 1
1 1 0 1
1 1 1 1

정답:
3
 
 */