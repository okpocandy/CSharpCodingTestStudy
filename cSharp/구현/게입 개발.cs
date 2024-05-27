using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 게입_개발
    {
        static void Main(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] XYD = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] map = new int[NM[0]][];
            int[,] map_visit = new int[NM[0],NM[1]];
          
            for (int i = NM[0] - 1; i >= 0; i--)
            {
                map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            int[] dx = new int[4] { 0, -1, 0, 1 };
            int[] dy = new int[4] { 1, 0, -1, 0 };
            
            int dir = XYD[2];
            int x = XYD[0];
            int y = NM[1] - XYD[1] - 1;
            map_visit[y, x] = 1;

            int count = 1;
            int turnTime = 0;
            while(true)
            {
                dir = TurnLeft(dir);
                int nx = x + dx[dir];
                int ny = y + dy[dir];

                if (map[ny][nx] == 0 && map_visit[ny,nx] == 0)
                {
                    map_visit[ny,nx] = 1;
                    x = nx;
                    y = ny;
                    count++;
                    turnTime = 0;
                    continue;
                }
                else
                {
                    turnTime++;
                }
                if(turnTime == 4)
                {
                    nx = x - dx[dir];
                    ny = y - dy[dir];
                    if (map[ny][nx] == 0)
                    {
                        x = nx;
                        y = ny;
                    }
                    else
                    {
                        break;
                    }
                    turnTime = 0;
                }
            }
            Console.WriteLine(count);

        }

        private static int TurnLeft(int dir)
        {
            dir++;
            if (dir == 4)
            {
                dir = 0;
            }

            return dir;
        }
    }
}

/*
 
4 4
1 1 0
1 1 1 1
1 0 0 1
1 1 0 1
1 1 1 1
 
 */