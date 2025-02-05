using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _1로_만들기
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[30001];
            dp[0] = 0;
            dp[1] = 0;
            for(int i= 2; i<n+1; i++)
            {
                dp[i] = dp[i - 1] + 1;
                if (i % 2 == 0)
                    dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
                if (i % 3 == 0)
                    dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
                if (i % 5 == 0)
                    dp[i] = Math.Min(dp[i], dp[i / 5] + 1);
            }
            Console.WriteLine(dp[n]);
      
        
        }
    }
}

/*

입력:
26

출력:
3
 

 */