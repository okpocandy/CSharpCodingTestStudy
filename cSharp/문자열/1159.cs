using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _1159
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<char, int> firstNameCount = new Dictionary<char, int>();

            // 입력을 읽고 첫 글자별 카운팅
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                char firstChar = name[0];

                if (firstNameCount.ContainsKey(firstChar))
                    firstNameCount[firstChar]++;
                else
                    firstNameCount[firstChar] = 1;
            }

            // 선발 가능한 첫 글자들을 저장
            List<char> selected = new List<char>();

            foreach (var entry in firstNameCount)
            {
                if (entry.Value >= 5)
                    selected.Add(entry.Key);
            }

            // 결과 출력
            if (selected.Count == 0)
            {
                Console.WriteLine("PREDAJA");
            }
            else
            {
                selected.Sort();  // 사전순 정렬
                Console.WriteLine(string.Join("", selected));
            }
        }
    }
}
