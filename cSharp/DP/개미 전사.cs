using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.DP
{
    internal class 개미_전사
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] dp = new int[100];
            dp[0] = arr[0];
            dp[1] = Math.Max(arr[0], arr[1]);
            for(int i=2; i<n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + arr[i]);
            }

            Console.WriteLine(dp[n - 1]);
        }
        
        
    }
}

/*
 
입력:
4
1 3 1 5
출력:
8
 
 */
