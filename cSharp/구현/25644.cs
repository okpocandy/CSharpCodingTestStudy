using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] prices = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            // 최소 주가 갱신
            if (price < minPrice)
                minPrice = price;

            // 최대 이익 갱신
            int profit = price - minPrice;
            if (profit > maxProfit)
                maxProfit = profit;
        }

        Console.WriteLine(maxProfit);
    }
}
