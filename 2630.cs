using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _2630
    {
        static int[,] graph;
        static int w = 0;
        static int b = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            graph = new int[n + 1, n + 1];
            for(int i=0; i<n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0;j < n; j++)
                {
                    graph[i, j] = ints[j];
                }
            }
            Ans(0, 0, n);
            Console.WriteLine(w);
            Console.WriteLine(b);
        }
        
        static void Ans(int r, int c, int s)
        {
            int color = graph[r, c];
            bool eq = true;
            for(int i=r; i<r+s; i++)
            {
                for(int j=c; j<c+s; j++)
                {
                    if (graph[i,j] != color)
                    {
                        eq = false;
                        break;
                    }
                }
                if (!eq)
                    break;
            }
            if(eq)
            {
                if (color == 0)
                    w++;
                else
                    b++;
                return;
            }

            int nS = s / 2;
            Ans(r, c, nS);
            Ans(r, c+nS, nS);
            Ans(r+nS, c, nS);
            Ans(r + nS, c + nS, nS);

        }
    }
}
