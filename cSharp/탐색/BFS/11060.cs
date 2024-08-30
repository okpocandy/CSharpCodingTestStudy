using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.탐색.BFS
{
    internal class _11060
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] visited = new int[n];
            Array.Fill(visited, -1); // 방문 안한 곳은 -1로 초기화
            BFS(ints, n, visited);
            Console.WriteLine(visited[n - 1]);
        }

        static void BFS(int[] ints, int n, int[] visited)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            visited[0] = 0; // 시작 위치는 0번 점프

            while (q.Count > 0)
            {
                int loc = q.Dequeue();
                int ma = ints[loc];

                for (int i = 1; i <= ma; i++)
                {
                    int nextLoc = loc + i;
                    if (nextLoc >= n) break; // 배열의 끝을 넘는 경우는 무시

                    if (visited[nextLoc] == -1 || visited[nextLoc] > visited[loc] + 1)
                    {
                        visited[nextLoc] = visited[loc] + 1;
                        q.Enqueue(nextLoc);
                    }
                }
            }
        }
    }
}
