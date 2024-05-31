using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 바닥_공사
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dp = new int[1001];
            dp[1] = 1;
            dp[2] = 3;
            for(int i=3; i<n+1; i++)
            {
                dp[i] = (dp[i - 1] + 2 * dp[i - 2]) % 796796;
            }
            Console.WriteLine(dp[n]);
        }
    }
}
