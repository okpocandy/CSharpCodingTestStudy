using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Study.cSharp.기하
{
    internal class 정사각형
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()?.Trim() ?? "0"); // 테스트 케이스 수 입력
            StringBuilder result = new StringBuilder();

            for (int test = 0; test < t; test++)
            {
                List<(int x, int y)> points = new List<(int x, int y)>();

                for (int i = 0; i < 4; i++)
                {
                    var input = Console.ReadLine()?.Split();
                    if (input != null && input.Length == 2)
                    {
                        points.Add((int.Parse(input[0]), int.Parse(input[1])));
                    }
                }

                if (IsSquare(points))
                {
                    result.AppendLine("1");
                }
                else
                {
                    result.AppendLine("0");
                }
            }

            Console.Write(result.ToString());
        }

        static bool IsSquare(List<(int x, int y)> points)
        {
            List<int> distances = new List<int>();

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    distances.Add(GetDistanceSquared(points[i], points[j]));
                }
            }

            distances.Sort();

            // 정사각형 조건: 4개의 변 길이와 2개의 대각선 길이가 있어야 함
            return distances[0] > 0 &&
                   distances[0] == distances[1] &&
                   distances[1] == distances[2] &&
                   distances[2] == distances[3] &&
                   distances[4] == distances[5] &&
                   distances[4] == 2 * distances[0];
        }

        static int GetDistanceSquared((int x, int y) p1, (int x, int y) p2)
        {
            int dx = p1.x - p2.x;
            int dy = p1.y - p2.y;
            return dx * dx + dy * dy; // 제곱 거리 반환
        }
    }
}
