using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _11663
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];

            int[] points = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(points); // 점 정렬

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < m; i++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int start = line[0];
                int end = line[1];

                // 범위 내 점의 개수 계산
                int lowerBound = LowerBound(points, start);
                int upperBound = UpperBound(points, end);

                sb.AppendLine((upperBound - lowerBound).ToString());
            }

            Console.Write(sb.ToString());
        }

        static int LowerBound(int[] arr, int target)
        {
            int left = 0, right = arr.Length;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] < target) left = mid + 1;
                else right = mid;
            }

            return left;
        }

        static int UpperBound(int[] arr, int target)
        {
            int left = 0, right = arr.Length;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] <= target) left = mid + 1;
                else right = mid;
            }

            return left;
        }
    }
}
