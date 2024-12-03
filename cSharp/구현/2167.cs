using System;

class Program
{
    static void Main(string[] args)
    {
        // 입력 받기
        string[] size = Console.ReadLine().Split();
        int n = int.Parse(size[0]);
        int m = int.Parse(size[1]);

        int[,] array = new int[n + 1, m + 1];
        int[,] prefixSum = new int[n + 1, m + 1];

        // 배열 입력 및 구간 합 배열 생성
        for (int i = 1; i <= n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 1; j <= m; j++)
            {
                array[i, j] = int.Parse(row[j - 1]);
                prefixSum[i, j] = array[i, j] + prefixSum[i - 1, j] + prefixSum[i, j - 1] - prefixSum[i - 1, j - 1];
            }
        }

        // 질의 처리
        int k = int.Parse(Console.ReadLine());
        for (int q = 0; q < k; q++)
        {
            string[] query = Console.ReadLine().Split();
            int i = int.Parse(query[0]);
            int j = int.Parse(query[1]);
            int x = int.Parse(query[2]);
            int y = int.Parse(query[3]);

            int result = prefixSum[x, y] - prefixSum[i - 1, y] - prefixSum[x, j - 1] + prefixSum[i - 1, j - 1];
            Console.WriteLine(result);
        }
    }
}
