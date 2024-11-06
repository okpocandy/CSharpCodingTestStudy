using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] dp = new int[n + 1];

        // DP 초기화
        dp[0] = 0;

        for (int i = 1; i <= n; i++)
        {
            dp[i] = i; // 최악의 경우 모든 항이 1^2인 경우 (개수 = i)
            for (int j = 1; j * j <= i; j++)
            {
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
        }

        Console.WriteLine(dp[n]);
    }
}
