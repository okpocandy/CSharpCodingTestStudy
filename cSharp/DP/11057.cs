using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _11057
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] dp = new int[n,10];
            for(int i=0; i<10; i++)
            {
                dp[0, i] = 1;
            }
            for(int i=1; i<n; i++)
            {
                for(int j=0; j<10; j++)
                {
                    for(int k=0; k<=j; k++)
                    {
                        dp[i, j] += dp[i-1, k] % 10007;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += dp[n - 1, i];
            }
            Console.WriteLine(sum % 10007);
        }
    }
}
