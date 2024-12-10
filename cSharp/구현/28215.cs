using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Study
{
    class Shelter
    {
        static void Main(string[] args)
        {
            // 입력 처리
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = firstLine[0], K = firstLine[1];
            var houses = new List<(int x, int y)>();

            for (int i = 0; i < N; i++)
            {
                var coords = Console.ReadLine().Split().Select(int.Parse).ToArray();
                houses.Add((coords[0], coords[1]));
            }

            // 모든 조합 탐색
            int minMaxDistance = int.MaxValue;

            foreach (var shelterComb in GetCombinations(houses, K))
            {
                int maxDistance = 0;

                foreach (var house in houses)
                {
                    int closestDistance = int.MaxValue;

                    foreach (var shelter in shelterComb)
                    {
                        int distance = Math.Abs(house.x - shelter.x) + Math.Abs(house.y - shelter.y);
                        closestDistance = Math.Min(closestDistance, distance);
                    }

                    maxDistance = Math.Max(maxDistance, closestDistance);
                }

                minMaxDistance = Math.Min(minMaxDistance, maxDistance);
            }

            // 결과 출력
            Console.WriteLine(minMaxDistance);
        }

        // 조합 생성 함수
        static IEnumerable<List<T>> GetCombinations<T>(List<T> list, int count)
        {
            int n = list.Count;

            if (count == 0) yield return new List<T>();
            else if (n == 0) yield break;
            else
            {
                var first = list[0];
                var rest = list.Skip(1).ToList();

                foreach (var combination in GetCombinations(rest, count - 1))
                {
                    combination.Insert(0, first);
                    yield return combination;
                }

                foreach (var combination in GetCombinations(rest, count))
                {
                    yield return combination;
                }
            }
        }
    }
}
