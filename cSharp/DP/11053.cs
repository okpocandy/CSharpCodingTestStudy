using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _11053
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] dp = new int[n];
            Array.Fill(dp, 1);
            dp[0] = 1;
            for(int i=1; i<n; i++)
            {
                for(int j=0; j<i; j++)
                {
                    if (ints[i] > ints[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j]+1);
                    }
                }
            }
            Console.WriteLine(dp.Max());
        }
    }
}
