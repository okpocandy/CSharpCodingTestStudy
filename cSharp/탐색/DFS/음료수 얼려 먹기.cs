using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색.DFS
{
    internal class 음료수_얼려_먹기
    {
        static int n;
        static int m;
        static char[][] graph;
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n = nm[0];
            m = nm[1];
            graph = new char[n][];
            for(int i=0; i<n; i++)
            {
                var inputs = Console.ReadLine().ToCharArray();
                graph[i] = inputs;
            }
            int ans = 0;
            for(int i=0; i<n;i++)
            {
                for(int j=0; j<m; j++)
                {
                    if (DFS(i, j))
                        ans++;
                }
            }
            Console.WriteLine(ans);
        }

        static bool DFS(int x, int y)
        {
            if (x < 0 || y < 0 || x >= m || y >= n)
                return false;
            if (graph[y][x] == '0')
            {
                graph[y][x] = '1';
                DFS(x + 1, y);
                DFS(x - 1, y);
                DFS(x, y + 1);
                DFS(x, y - 1);
                return true;
            }
            return false;
        }
    }
}

/*
 
입력:
15 14
00000111100000
11111101111110
11011101101110
11011101100000
11011111111111
11011111111100
11000000111111
01111111111111
00000000011111
01111111111000
00011111111000
00000001111000
11111111110011
11100011111111
11100011111111
 
 
 
 
 */