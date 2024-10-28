using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> words = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine().Trim();
            words.Add(word); // 중복된 단어를 무시하기 위해 HashSet 사용
        }

        // 단어를 길이에 따라 정렬
        var sortedWords = words.OrderBy(w => w.Length).ToList();

        // 접두사 X 집합 만들기
        List<string> prefixFreeSet = new List<string>();

        foreach (var word in sortedWords)
        {
            bool isPrefix = false;

            // 현재 단어가 prefixFreeSet의 어떤 단어의 접두사인지 체크
            foreach (var selectedWord in prefixFreeSet)
            {
                if (selectedWord.StartsWith(word))
                {
                    isPrefix = true; // 접두사 관계가 있음
                    break;
                }
            }

            // 현재 단어가 어떤 접두사도 아닐 경우 추가
            if (!isPrefix)
            {
                prefixFreeSet.Add(word);
            }
        }

        // 접두사 X 집합의 크기 출력
        Console.WriteLine(prefixFreeSet.Count);
    }
}
