using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class 음료수_얼려_먹기
    {
        static int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        static int[,] graph = new int[NM[0], NM[1]];
        static void Main(string[] args)
        {
            for (int i=0; i < NM[0]; i++)
            {
                string line = Console.ReadLine();
                for(int j=0; j < NM[1];  j++)
                {
                    graph[i, j] = (int)(line[j] - '0');
                }
            }

            int result = 0;
            for(int i=0; i < NM[0];i++)
            {
                for(int j=0; j < NM[1];j++)
                {
                    if (DFS(j, i) == true)
                        result++;
                }
            }
            Console.WriteLine(result);

        }

        static bool DFS(int x, int y)
        {
            if(x <= -1 || x >= NM[1] ||  y <= -1 || y >= NM[0])
                return false;

            if (graph[y,x] == 0)
            {
                graph[y, x] = 1;
                DFS(x-1,y); // true or false
                DFS(x, y-1);
                DFS(x+1, y);
                DFS(x, y+1);
                return true;
            }
            return false;
        }
    }
}


/*
 
4 5
00110
00011
11111
00000


15 14
00000111100000
11111101111110
11011101101110
11011101100000
11011111111111
11011111111100
11000000011111
01111111111111
00000000011111
01111111111000
00011111111000
00000001111000
11111111110011
11100011111111
11100011111111


 */