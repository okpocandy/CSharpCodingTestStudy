using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class 개미_전사
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] dp = new int[100];
            dp[0] = array[0];
            dp[1] = Math.Max(array[1], array[0]);

            for(int i=2; i<n;i++)
            {
                dp[i] = Math.Max(dp[i - 2] + array[i], dp[i-1]);
            }
            Console.WriteLine(dp[n-1]);
        }
    }
}

/*

4
1 3 1 5

*/