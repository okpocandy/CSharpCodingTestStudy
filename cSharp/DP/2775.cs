using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _2775
    {
        static void Main(string[] args)
        {
            int[,] apart = new int[15, 14];
            int sum = 0;
            for (int i = 0; i < apart.GetLength(1); i++)
            {
                apart[0, i] = i + 1;
            }
            for (int i = 1; i < apart.GetLength(0); i++)
            {
                for (int j = 0; j < apart.GetLength(1); j++)
                {
                    if (j == 0)
                        apart[i, j] = 1;
                    else
                        apart[i, j] = apart[i, j - 1] + apart[i - 1, j];
                }
            }


            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(apart[k, n - 1]);
            }
        }
    }
}
