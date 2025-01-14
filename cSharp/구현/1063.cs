using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1063
    {
        static bool IsIn(int y,int x)
        {
            if (y >= 0 && x >= 0 && y <= 7 && x <= 7)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            string[] ksn = Console.ReadLine().Split();
            string k = ksn[0];
            int kx = (int)k[0] - (int)'A';
            int ky = (int)k[1] - (int)'0'-1;
            string s = ksn[1];
            int sx = (int)s[0] - (int)'A';
            int sy = (int)s[1] - (int)'0'-1;
            
            int n = int.Parse(ksn[2]);
            for(int i=0; i<n; i++)
            {
                string move = Console.ReadLine();
                switch(move)
                {
                    case "R":
                        {
                            int ny = ky;
                            int nx = kx+1;
                            int nsy = sy;
                            int nsx = sx;
                            if (ny == sy && nx == sx)
                            {
                                nsx = sx+1;
                            }
                            if(IsIn(ny, nx) && IsIn(nsy, nsx))
                            {
                                ky = ny;
                                kx = nx;
                                sy = nsy;
                                sx = nsx;
                            }
                        }
                        break;
                    case "L":
                        {
                            int ny = ky;
                            int nx = kx - 1;
                            int nsy = sy;
                            int nsx = sx;
                            if (ny == sy && nx == sx)
                            {
                                nsx = sx - 1;
                            }
                            if (IsIn(ny, nx) && IsIn(nsy, nsx))
                            {
                                ky = ny;
                                kx = nx;
                                sy = nsy;
                                sx = nsx;
                            }
                        }
                        break;
                    case "T":
                        {
                            int ny = ky + 1;
                            int nx = kx;
                            int nsy = sy;
                            int nsx = sx;
                            if (ny == sy && nx == sx)
                            {
                                nsy = sy + 1;
                            }
                            if (IsIn(ny, nx) && IsIn(nsy, nsx))
                            {
                                ky = ny;
                                kx = nx;
                                sy = nsy;
                                sx = nsx;
                            }
                        }
                        break;
                    case "B":
                        {
                            int ny = ky - 1;
                            int nx = kx;
                            int nsy = sy;
                            int nsx = sx;
                            if (ny == sy && nx == sx)
                            {
                                nsy = sy - 1;
                            }
                            if (IsIn(ny, nx) && IsIn(nsy, nsx))
                            {
                                ky = ny;
                                kx = nx;
                                sy = nsy;
                                sx = nsx;
                            }
                        }
                        break;
                    case "RT":
                        {
                            int ny = ky + 1;
                            int nx = kx + 1;
                            int nsy = sy;
                            int nsx = sx;
                            if (ny == sy && nx == sx)
                            {
                                nsx = sx + 1;
                                nsy = sy + 1;
                            }
                            if (IsIn(ny, nx) && IsIn(nsy, nsx))
                            {
                                ky = ny;
                                kx = nx;
                                sy = nsy;
                                sx = nsx;
                            }
                        }
                        break;
                    case "LT":
                        {
                            int ny = ky + 1;
                            int nx = kx - 1;
                            int nsy = sy;
                            int nsx = sx;
                            if (ny == sy && nx == sx)
                            {
                                nsx = sx - 1;
                                nsy = sy + 1;
                            }
                            if (IsIn(ny, nx) && IsIn(nsy, nsx))
                            {
                                ky = ny;
                                kx = nx;
                                sy = nsy;
                                sx = nsx;
                            }
                        }
                        break;
                    case "RB":
                        {
                            int ny = ky - 1;
                            int nx = kx + 1;
                            int nsy = sy;
                            int nsx = sx;
                            if (ny == sy && nx == sx)
                            {
                                nsx = sx + 1;
                                nsy = sy - 1;
                            }
                            if (IsIn(ny, nx) && IsIn(nsy, nsx))
                            {
                                ky = ny;
                                kx = nx;
                                sy = nsy;
                                sx = nsx;
                            }
                        }
                        break;
                    case "LB":
                        {
                            int ny = ky - 1;
                            int nx = kx - 1;
                            int nsy = sy;
                            int nsx = sx;
                            if (ny == sy && nx == sx)
                            {
                                nsx = sx - 1;
                                nsy = sy - 1;
                            }
                            if (IsIn(ny, nx) && IsIn(nsy, nsx))
                            {
                                ky = ny;
                                kx = nx;
                                sy = nsy;
                                sx = nsx;
                            }
                        }
                        break;
                }
                
            }
            Console.WriteLine((char)(kx+65) +""+ (ky+1));
            Console.WriteLine((char)(sx+65) +""+ (sy+1));
        }
    }
}
