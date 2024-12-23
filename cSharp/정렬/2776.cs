using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _2776
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()?.Trim() ?? "0"); // 테스트 케이스 수 입력
            for (int test = 0; test < t; test++)
            {
                int n = int.Parse(Console.ReadLine()?.Trim() ?? "0"); // 수첩1 크기
                HashSet<int> note1 = new HashSet<int>();
                string? note1Input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(note1Input))
                {
                    foreach (string num in note1Input.Split())
                    {
                        if (int.TryParse(num, out int parsedNum))
                        {
                            note1.Add(parsedNum);
                        }
                    }
                }

                int m = int.Parse(Console.ReadLine()?.Trim() ?? "0"); // 수첩2 크기
                string? note2Input = Console.ReadLine()?.Trim();
                StringBuilder result = new StringBuilder();

                if (!string.IsNullOrEmpty(note2Input))
                {
                    foreach (string num in note2Input.Split())
                    {
                        if (int.TryParse(num, out int query))
                        {
                            result.AppendLine(note1.Contains(query) ? "1" : "0");
                        }
                    }
                }

                Console.Write(result.ToString());
            }
        }
    }
}
