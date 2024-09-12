using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.자료구조.딕셔너리와_해시
{
    internal class _14425
    {
        static void Main(string[] args)
        {
            // 입력 처리
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];

            // 집합 S를 HashSet으로 처리
            HashSet<string> s = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                s.Add(Console.ReadLine());
            }

            // 검사할 문자열들을 입력받아 S에 포함된 것인지 확인
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                string check = Console.ReadLine();
                if (s.Contains(check))
                {
                    count++;
                }
            }

            // 결과 출력
            Console.WriteLine(count);
        }
    }
}
