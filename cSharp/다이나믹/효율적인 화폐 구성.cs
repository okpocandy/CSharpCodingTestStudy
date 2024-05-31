using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp
{
    internal class 효율적인_화폐_구성
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] array = new int[n];
            int[] dp = new int[m + 1];
            Array.Fill(dp, 10001);
            dp[0] = 0;
            for (int i = 0; i < n; i++) { array[i] = int.Parse(Console.ReadLine()); }

            for (int i = 0; i < n; i++)
            {
                for (int j = array[i]; j < m + 1; j++)
                {
                    if (dp[j] - array[i] != 10001)
                    {
                        dp[j] = Math.Min(dp[j - array[i]] + 1, dp[j]);
                    }
                }
            }

            if (dp[m] == 10001)
                Console.WriteLine(-1);
            else
                Console.WriteLine(dp[m]);
        }
    }
}

/*
 
2 15
2
3


3 4
3
5
7



 */
