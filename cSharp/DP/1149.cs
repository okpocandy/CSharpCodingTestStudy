using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _1149
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] dp = new int[n, 3];
            int[] tmp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            dp[0, 0] = tmp[0];
            dp[0, 1] = tmp[1];
            dp[0, 2] = tmp[2];
            for(int i=1; i<n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i - 1, 2]) + ints[0];
                dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 2]) + ints[1];
                dp[i, 2] = Math.Min(dp[i - 1, 1], dp[i - 1, 0]) + ints[2];
            }
            Console.WriteLine(new[] { dp[n-1,0], dp[n-1, 1], dp[n-1,2] }.Min());

        }
    }
}
