using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _14381
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // 테스트 케이스 개수 입력
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()); // 각 테스트 케이스의 N 값
                string ans = "";

                if (n == 0) // N이 0일 경우 불면증
                {
                    ans = "INSOMNIA";
                }
                else
                {
                    HashSet<char> digitsSeen = new HashSet<char>(); // 기록된 숫자
                    int multiplier = 0;
                    int currentNumber = 0;

                    while (digitsSeen.Count < 10) // 모든 숫자(0~9)가 기록될 때까지 반복
                    {
                        multiplier++;
                        currentNumber = n * multiplier; // i * N
                        foreach (var digit in currentNumber.ToString())
                        {
                            digitsSeen.Add(digit); // 자릿수 추가
                        }
                    }
                    ans = currentNumber.ToString(); // 블리트릭스가 잠드는 수
                }

                Console.WriteLine($"Case #{i + 1}: {ans}"); // 결과 출력
            }
        }
    }
}
