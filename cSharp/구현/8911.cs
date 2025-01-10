using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _8911
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<t; i++)
            {
                
                int sy = 500;
                int sx = 500;
                int maxy = sy;
                int miny = sy;
                int maxx = sx;
                int minx = sx;
                int[] dy = new int[4] { -1, 0, 1, 0 };
                int[] dx = new int[4] { 0, 1, 0, -1 };
                int dir = 0;
                string moves = Console.ReadLine();
                foreach(char c in moves)
                {
                    switch(c)
                    {
                        case 'F':
                            {
                                sy = sy + dy[dir];
                                sx = sx + dx[dir];
                                maxy = Math.Max(maxy, sy);
                                miny = Math.Min(miny, sy);
                                maxx = Math.Max(maxx, sx);
                                minx = Math.Min(minx, sx);
                                break;
                            }
                        case 'B':
                            {
                                sy = sy - dy[dir];
                                sx = sx - dx[dir];
                                maxy = Math.Max(maxy, sy);
                                miny = Math.Min(miny, sy);
                                maxx = Math.Max(maxx, sx);
                                minx = Math.Min(minx, sx);
                                break;
                            }
                        case 'L':
                            {
                               
                                dir--;
                                if (dir == -1)
                                    dir = 3;
                                break;
                            }
                        case 'R':
                            {
                                dir++;
                                if (dir == 4)
                                    dir = 0;
                                break;
                            }
                    }
                }
                sb.AppendLine(((maxy - miny)*(maxx - minx)).ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
