using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1051
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            string[] ls = new string[n];
            for (int i = 0; i < n; i++)
            {
                ls[i] = Console.ReadLine();

            }
            int mi = Math.Min(n, m);
            int ans = 0;
            for (int i = 1; i < mi; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    for (int k = 0; k < m - i; k++)
                    {
                        if (ls[j][k] == ls[j + i][k] && ls[j][k] == ls[j][k + i] && ls[j][k] == ls[j + i][k + i])
                            ans = i;
                    }
                }
            }
            Console.WriteLine((ans + 1) * (ans + 1));
        }
    }
}
