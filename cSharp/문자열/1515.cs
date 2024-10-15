using System;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _3976
    {
        static void Main(string[] args)
        {
            string target = Console.ReadLine();  // 남은 문자열 입력
            int N = 1;  // N의 초기값
            int index = 0;  // target 문자열의 탐색 인덱스

            // 1부터 시작하여 N을 증가시켜가며 확인
            while (index < target.Length)
            {
                string current = N.ToString();  // 현재 N을 문자열로 변환

                // current의 각 문자를 하나씩 target과 매칭
                foreach (char c in current)
                {
                    if (index < target.Length && target[index] == c)
                    {
                        index++;  // 일치하면 target의 다음 문자로 이동
                    }
                }

                N++;  // N 증가
            }

            // 최종적으로 N-1이 최소 N 값이므로 출력
            Console.WriteLine(N - 1);
        }
    }
}
