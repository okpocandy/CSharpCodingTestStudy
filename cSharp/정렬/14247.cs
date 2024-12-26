using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 입력
        int n = int.Parse(Console.ReadLine());
        int[] H = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // 나무 정보 정렬: 성장률 A를 기준으로 내림차순 정렬, 같은 성장률에서는 초기 길이 H 기준
        var trees = Enumerable.Range(0, n)
            .Select(i => new { H = H[i], A = A[i] })
            .OrderByDescending(tree => tree.A)
            .ThenByDescending(tree => tree.H)
            .ToList();

        // 최대 길이 계산
        long maxWood = 0;
        for (int day = 0; day < n; day++)
        {
            maxWood += trees[day].H + (long)trees[day].A * day;
        }

        // 출력
        Console.WriteLine(maxWood);
    }
}
