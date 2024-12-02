using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.구현
{
    class _27964
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split();
            HashSet<string> uniqueCheeses = new HashSet<string>(); // 치즈 종류를 저장

            foreach (string input in inputs)
            {
                // 길이가 6 이상이고, "Cheese"로 끝나는 경우만 처리
                if (input.Length >= 6 && input.EndsWith("Cheese"))
                {
                    string cheeseName = input.Substring(0, input.Length - 6); // "Cheese"를 제외한 이름
                    uniqueCheeses.Add(cheeseName); // Set에 추가하여 중복 방지
                }
            }

            // 결과 출력
            if (uniqueCheeses.Count >= 4)
                Console.WriteLine("yummy");
            else
                Console.WriteLine("sad");
        }
    }
}
