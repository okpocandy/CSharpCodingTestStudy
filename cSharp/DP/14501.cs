using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class _14501
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int[]> shedule = new List<int[]>();
            int[] dp = new int[n+1];
            for(int i=0; i<n; i++)
            {
                shedule.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            }
            for(int i=0; i<n; i++)
            {
                if (dp[i] > dp[i + 1])
                {
                    dp[i + 1] = dp[i];
                }
                if (shedule[i][0] + i <= (n))
                {
                    dp[shedule[i][0] + i] = Math.Max(shedule[i][1] + dp[i], dp[shedule[i][0] + i]);
                }
            }
            foreach(var i in dp)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(dp.Max());

        }
    }
}
