using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 생일다국어
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(string name, int day, int month, int year)> students = new List<(string, int, int, int)>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int day = int.Parse(input[1]);
                int month = int.Parse(input[2]);
                int year = int.Parse(input[3]);
                students.Add((name, day, month, year));
            }

            // 생일 기준 정렬 (연도 → 월 → 일 오름차순)
            students = students.OrderBy(s => s.year)
                               .ThenBy(s => s.month)
                               .ThenBy(s => s.day)
                               .ToList();

            // 결과 출력
            Console.WriteLine(students.Last().name); // 가장 나이가 적은 사람
            Console.WriteLine(students.First().name); // 가장 나이가 많은 사람
        }
    }
}
