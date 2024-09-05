using System;
using System.Text;

namespace C_Sharp_Study
{
    internal class ReverseWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            StringBuilder word = new StringBuilder();
            bool inTag = false;

            foreach (char c in input)
            {
                if (c == '<')
                {
                    // 태그 시작 시, 단어가 있으면 뒤집어서 추가
                    if (word.Length > 0)
                    {
                        for (int i = word.Length - 1; i >= 0; i--)
                            result.Append(word[i]);
                        word.Clear();
                    }
                    inTag = true;
                    result.Append(c); // 태그는 그대로 추가
                }
                else if (c == '>')
                {
                    inTag = false;
                    result.Append(c); // 태그는 그대로 추가
                }
                else if (inTag)
                {
                    result.Append(c); // 태그 내부는 그대로 추가
                }
                else
                {
                    if (c == ' ')
                    {
                        // 단어를 만나면 뒤집어서 추가
                        for (int i = word.Length - 1; i >= 0; i--)
                            result.Append(word[i]);
                        result.Append(' '); // 공백 추가
                        word.Clear();
                    }
                    else
                    {
                        word.Append(c); // 단어 구성
                    }
                }
            }

            // 마지막 단어 처리
            if (word.Length > 0)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                    result.Append(word[i]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
