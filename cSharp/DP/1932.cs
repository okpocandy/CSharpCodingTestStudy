using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _1932
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int[]> ls = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                ls.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); ;

            }
            List<int[]> dp = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                dp.Add(new int[i + 1]);
            }
            dp[0][0] = ls[0][0];
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                        dp[i][j] = dp[i - 1][j] + ls[i][j];
                    else if (j == i)
                        dp[i][j] = dp[i - 1][j - 1] + ls[i][j];
                    else
                        dp[i][j] = Math.Max(dp[i - 1][j - 1], dp[i - 1][j]) + ls[i][j];
                }
            }
            Console.WriteLine(dp[n - 1].Max());
        }
    }
}
