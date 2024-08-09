using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _1904
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] d = new int[1000001];
            d[0] = 0;
            d[1] = 1;
            d[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                d[i] = (d[i - 2] + d[i - 1]) % 15746;
            }
            Console.WriteLine(d[n]);
        }
    }
}
