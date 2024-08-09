using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _2193
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[,] dp = new long[n + 1, 2];
            dp[0, 0] = 0;
            dp[0, 1] = 0;
            dp[1, 0] = 0;
            dp[1, 1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + dp[i - 1, 1];
                dp[i, 1] = dp[i - 1, 0];
            }
            Console.WriteLine(dp[n, 0] + dp[n, 1]);
        }
    }
}
