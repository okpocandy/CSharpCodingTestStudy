using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Study.cSharp.문자열
{
    class _20920
    {
        static void Main(string[] args)
        {
            // 입력 처리
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];

            // 단어와 빈도를 저장할 딕셔너리
            Dictionary<string, int> dic = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            // 단어 입력 및 빈도 카운팅
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                // 단어의 길이가 M 이상일 때만 처리
                if (word.Length >= m)
                {
                    if (dic.ContainsKey(word))
                        dic[word]++;
                    else
                        dic[word] = 1;
                }
            }

            // 단어장을 조건에 따라 정렬
            var sortedWords = dic
                .OrderByDescending(kv => kv.Value)    // 출현 빈도 내림차순
                .ThenByDescending(kv => kv.Key.Length) // 단어 길이 내림차순
                .ThenBy(kv => kv.Key)                  // 알파벳 순서 오름차순
                .Select(kv => kv.Key);                 // 단어만 추출

            // 결과 출력
            foreach (var word in sortedWords)
            {
                sb.AppendLine(word);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
