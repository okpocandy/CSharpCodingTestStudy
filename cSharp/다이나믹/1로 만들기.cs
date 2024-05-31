using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _1로_만들기
    {
        
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] dp = new int[x+1];
            dp[0] = 0;
            dp[1] = 0;

            for (int i=2; i<x+1;i++)
            {
                dp[i] = dp[i - 1] + 1;
                if (i % 5 == 0)
                {
                    dp[i] = Math.Min(dp[i / 5] + 1, dp[i]);
                }
                if(i% 3 == 0)
                    dp[i] = Math.Min(dp[i/3] + 1, dp[i]);
                if (i % 2 == 0)
                    dp[i] = Math.Min(dp[i / 2] + 1, dp[i]);
                    
            }
            Console.WriteLine(dp[x]);

        }
    }
}
