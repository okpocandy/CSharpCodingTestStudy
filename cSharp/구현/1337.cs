using System;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 올바른배열
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // 배열을 정렬
            Array.Sort(arr);

            int minAdd = int.MaxValue;

            // 슬라이딩 윈도우 탐색
            for (int i = 0; i < n; i++)
            {
                // 현재 윈도우의 끝 범위를 찾기
                int j = i;
                while (j < n && arr[j] - arr[i] < 5)
                {
                    j++;
                }

                // 윈도우 크기 계산
                int currentSize = j - i;
                int missing = 5 - currentSize;
                minAdd = Math.Min(minAdd, missing);
            }

            Console.WriteLine(minAdd);
        }
    }
}
