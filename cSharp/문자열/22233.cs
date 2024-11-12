using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _22233
    {
        static void Main(string[] args)
        {
            // StringBuilder를 사용하여 출력을 모아서 한 번에 처리
            StringBuilder output = new StringBuilder();

            // 입력 첫 줄 처리
            string[] nm = Console.ReadLine().Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            // 키워드를 HashSet에 저장
            HashSet<string> keywords = new HashSet<string>();

            // 키워드 입력
            for (int i = 0; i < n; i++)
            {
                keywords.Add(Console.ReadLine());
            }

            // 삭제 작업
            for (int i = 0; i < m; i++)
            {
                string[] inputKeywords = Console.ReadLine().Split(',');

                foreach (string key in inputKeywords)
                {
                    // 키워드가 존재하면 제거
                    keywords.Remove(key);
                }

                // 남아있는 키워드 개수를 StringBuilder에 추가
                output.AppendLine(keywords.Count.ToString());
            }

            // 전체 출력 한 번에 처리
            Console.Write(output.ToString());
        }
    }
}
