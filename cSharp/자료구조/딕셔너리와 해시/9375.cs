using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int testCaseCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCaseCount; i++)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> clothes = new Dictionary<string, int>();

            // 의상 정보를 입력받아 종류별로 그룹화
            for (int j = 0; j < n; j++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[1];

                if (clothes.ContainsKey(type))
                    clothes[type]++;
                else
                    clothes[type] = 1;
            }

            int result = 1;

            // 각 종류별 경우의 수를 곱셈하여 계산
            foreach (int count in clothes.Values)
            {
                result *= (count + 1);
            }

            // 알몸인 경우 제외
            Console.WriteLine(result - 1);
        }
    }
}
