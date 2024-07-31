using System;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _5525
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int cnt = 0;
            int patternCount = 0;

            for (int i = 1; i < m - 1; i++)
            {
                // 'IOI' 패턴을 찾음
                if (s[i] == 'O' && s[i + 1] == 'I' && s[i - 1] == 'I')
                {
                    patternCount++;
                    if (patternCount == n)
                    {
                        cnt++;
                        patternCount--; // 다음 패턴을 위해 중복된 'OI'를 하나 제거
                    }
                    i++; // 다음 'OI' 패턴을 찾기 위해 인덱스를 하나 건너뜀
                }
                else
                {
                    patternCount = 0; // 패턴이 끊어지면 초기화
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
