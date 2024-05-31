using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.DFS
{
    internal class _4936
    {
        static int[] dx = { 0, 1, 0, -1, 1, 1, -1, -1 };
        static int[] dy = { 1, 0, -1, 0, -1, 1, -1, 1 };
        static void Main(string[] args)
        {
            

            while (true)
            {
                int[] wh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int w = wh[0];
                int h = wh[1];
                if (w == 0 && h == 0) { break; }
                int[][] map = new int[h][];
                int[,] visited = new int[h, w];
                for (int i = 0; i < h; i++)
                {
                    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    map[i] = inputs;
                }
                int count = 0;
                for(int i=0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        if (map[j][i] == 1)
                        {
                            DFS(map, j, i);
                            count++;
                        }
                    }
                }
                Console.WriteLine(count);


            }
        }

        static void DFS(int[][]map, int y, int x)
        {
            map[y][x] = 0;
            for(int i=0; i < 8; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                if(nx < 0 || ny < 0 || nx >= map[0].Length || ny >= map.Length) { continue; }
                if (map[ny][nx] == 1)
                    DFS(map, ny, nx);
            }
        }
            

    }
}
