using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _26169
    {
        static int[] dx = new int[] { 0, 1, 0, -1 };
        static int[] dy = new int[] { 1, 0, -1, 0 };
        static int ans = 0;
        static void Main(string[] args)
        {
            int[][] map = new int[5][];
            for (int i = 0; i < map.GetLength(0); i++)
                map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] rc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int r = rc[0];
            int c = rc[1];

            DFS(map, c, r, 0, 0);
            Console.WriteLine(ans);
        }

        static void DFS(int[][] map, int x, int y, int count, int result)
        {
            if (count == 4)
                return;
            if (result == 2)
            {
                ans = 1;
                return;
            }

            int original = map[y][x];
            map[y][x] = -1;

            for(int i=0; i<4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                if (nx < 0 || ny < 0 || nx > 4 || ny > 4)
                    continue;
                if (map[ny][nx] != -1)
                {
                    DFS(map, nx, ny, count + 1, result + map[ny][nx]);
                }

            }

            map[y][x] = original;
        }
    }
}
