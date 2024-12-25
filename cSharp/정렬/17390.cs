using System;
using System.Text;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _17390
    {
        static void Main(string[] args)
        {
            int[] nq = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nq[0];
            int q = nq[1];

            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(a); // 비내림차순 정렬

            // Prefix Sum 배열 생성
            int[] prefixSum = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + a[i - 1];
            }

            StringBuilder sb = new StringBuilder();

            // 쿼리 처리
            for (int i = 0; i < q; i++)
            {
                int[] lr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int l = lr[0];
                int r = lr[1];

                // 구간 합 계산
                int sum = prefixSum[r] - prefixSum[l - 1];
                sb.AppendLine(sum.ToString());
            }

            Console.Write(sb.ToString());
        }
    }
}
