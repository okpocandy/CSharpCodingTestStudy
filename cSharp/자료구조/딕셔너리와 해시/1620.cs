using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.자료구조.딕셔너리와_해시
{
    internal class _1620
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];

            // 두 개의 딕셔너리를 사용하여 각 키와 값에 빠르게 접근 가능하게 합니다.
            Dictionary<int, string> dicNumberToName = new Dictionary<int, string>();
            Dictionary<string, int> dicNameToNumber = new Dictionary<string, int>();

            // 번호와 이름으로 각각 저장
            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                dicNumberToName[i] = name;
                dicNameToNumber[name] = i;
            }

            // 질의 처리
            for (int i = 0; i < m; i++)
            {
                string query = Console.ReadLine();

                if (int.TryParse(query, out int number))
                    Console.WriteLine(dicNumberToName[number]);  // 번호로 이름 출력
                else
                    Console.WriteLine(dicNameToNumber[query]);  // 이름으로 번호 출력
            }
        }
    }
}
