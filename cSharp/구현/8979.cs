using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        // 국가별 메달 데이터를 입력받음
        var countries = new (int id, int gold, int silver, int bronze)[n];
        for (int i = 0; i < n; i++)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            countries[i] = (line[0], line[1], line[2], line[3]);
        }

        // 메달 기준으로 정렬 후 등수 계산
        var ranked = countries
            .OrderByDescending(c => c.gold)
            .ThenByDescending(c => c.silver)
            .ThenByDescending(c => c.bronze)
            .ToList();

        // 국가 K의 점수 찾기
        var target = ranked.First(c => c.id == k);

        // 국가 K와 동일한 메달 순위를 가진 국가들 탐색
        int rank = ranked.Count(c =>
            c.gold > target.gold ||
            (c.gold == target.gold && c.silver > target.silver) ||
            (c.gold == target.gold && c.silver == target.silver && c.bronze > target.bronze)
        ) + 1;

        Console.WriteLine(rank);
    }
}
