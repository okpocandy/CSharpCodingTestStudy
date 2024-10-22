using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _2013
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<char> usedKeys = new HashSet<char>();  // 사용된 단축키를 저장 (대소문자 구분 없이)
            List<string> results = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] words = line.Split(' ');  // 단어별로 나눔
                bool shortcutAssigned = false;  // 단축키가 지정됐는지 여부

                // 1단계: 각 단어의 첫 글자 확인
                for (int j = 0; j < words.Length; j++)
                {
                    char firstChar = char.ToLower(words[j][0]);
                    if (!usedKeys.Contains(firstChar))
                    {
                        usedKeys.Add(firstChar);  // 단축키로 사용된 알파벳 저장
                        words[j] = $"[{words[j][0]}]{words[j].Substring(1)}";  // 첫 글자에 괄호 추가
                        shortcutAssigned = true;
                        break;
                    }
                }

                // 2단계: 첫 글자가 모두 사용된 경우, 각 단어의 나머지 글자 확인
                if (!shortcutAssigned)
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        for (int k = 1; k < words[j].Length; k++)
                        {
                            char ch = char.ToLower(words[j][k]);
                            if (!usedKeys.Contains(ch))
                            {
                                usedKeys.Add(ch);  // 단축키로 사용된 알파벳 저장
                                words[j] = $"{words[j].Substring(0, k)}[{words[j][k]}]{words[j].Substring(k + 1)}";  // 해당 글자에 괄호 추가
                                shortcutAssigned = true;
                                break;
                            }
                        }
                        if (shortcutAssigned) break;
                    }
                }

                // 결과 저장
                results.Add(string.Join(" ", words));
            }

            // 출력
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
