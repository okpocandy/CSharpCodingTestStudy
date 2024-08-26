using System;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1110
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int original = n;
            int cnt = 0;

            while (true)
            {
                int a = n / 10; // 십의 자리
                int b = n % 10; // 일의 자리
                int sum = (a + b) % 10; // 합의 일의 자리
                n = b * 10 + sum; // 새로운 수 생성
                cnt++;

                if (n == original)
                    break;
            }

            Console.WriteLine(cnt);
        }
    }
}