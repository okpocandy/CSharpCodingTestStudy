using System;

namespace StockProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // 테스트 케이스 수 입력
            for (int testCase = 0; testCase < t; testCase++)
            {
                int n = int.Parse(Console.ReadLine()); // 날의 수 입력
                long[] prices = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

                long maxPrice = 0; // 현재까지의 최대 주가
                long profit = 0;  // 최대 이익

                // 뒤에서부터 순회
                for (int i = n - 1; i >= 0; i--)
                {
                    if (prices[i] > maxPrice)
                    {
                        maxPrice = prices[i]; // 최대 주가 갱신
                    }
                    else
                    {
                        profit += maxPrice - prices[i]; // 이익 누적
                    }
                }

                Console.WriteLine(profit);
            }
        }
    }
}
