using System;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _8595
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            long ans = 0;  // 히든 넘버의 합 (long 사용)

            string tmp = "";  // 현재 숫자를 저장할 임시 변수

            for (int i = 0; i < n; i++)
            {
                if (char.IsDigit(s[i]))  // 현재 문자가 숫자인지 확인
                {
                    tmp += s[i];  // 숫자라면 tmp에 추가
                }
                else if (tmp != "")  // 숫자열이 끝났다면
                {
                    ans += long.Parse(tmp);  // 합산
                    tmp = "";  // 임시 변수 초기화
                }
            }

            // 마지막에 남아 있는 숫자 처리
            if (tmp != "")
            {
                ans += long.Parse(tmp);
            }

            Console.WriteLine(ans);  // 결과 출력
        }
    }
}
