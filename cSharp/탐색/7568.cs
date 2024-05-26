using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _7568
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] arrays = new int[N][];
            for (int i = 0; i < N; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                arrays[i] = xy;
            }
            int k = 0;
            int[] rank = new int[N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (arrays[i][0] < arrays[j][0] && arrays[i][1] < arrays[j][1])
                    {
                        k++;
                    }
                }
                rank[i] = k + 1;
                k = 0;
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(rank[i]);
                Console.Write(' ');
            }

        }
    }
}
