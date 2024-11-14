using System;

namespace ChocolateMeal
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());

            // 가장 작은 초콜릿 크기를 찾기 위해 2의 거듭제곱으로 증가
            int chocolateSize = 1;
            while (chocolateSize < K)
            {
                chocolateSize *= 2;
            }
            if (K == chocolateSize)
                Console.WriteLine($"{chocolateSize} 0");
            else
            {
                int splits = CountOnesInBinary(K, chocolateSize);

                // 결과 출력
                Console.WriteLine($"{chocolateSize} {splits}");
            }
            // 최소 분할 횟수는 K의 이진수에서 1의 개수와 동일
            
        }

        // 이진수에서 1의 개수 세기
        static int CountOnesInBinary(int k, int choco)
        {
            int count = 0;
            int re = choco;
            int tmp = k;
            while(tmp >0)
            {
                while (tmp < re)
                {
                    re /= 2;
                    count++;
                }
                tmp -= re;
            }
            return count;
        }
    }
}
