using System;
using System.Collections.Generic;

namespace C_Sharp_Study
{
    internal class _11123
    {
        static int[] dx = { 0, 1, 0, -1 };
        static int[] dy = { 1, 0, -1, 0 };
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int k = 0; k < T; k++)
            {
                int[] HW = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int h = HW[0];
                int w = HW[1];
                char[][] map = new char[h][];
                for (int i = 0; i < h; i++) { map[i] = Console.ReadLine().ToCharArray(); }

                int count = 0;
                for (int i = 0; i < h; i++) // 'h'와 'w'를 올바르게 사용
                {
                    for (int j = 0; j < w; j++) // 'h'와 'w'를 올바르게 사용
                    {
                        if (map[i][j] == '#')
                        {
                            BFS(map, i, j); // 'i'와 'j'의 순서가 올바름
                            count++;
                        }
                    }
                }
                Console.WriteLine(count);
            }
        }

        static void BFS(char[][] map, int y, int x)
        {
            Queue<int[]> q = new Queue<int[]>();
            q.Enqueue(new int[] { y, x }); // 배열 초기화
            map[y][x] = '.';
            while (q.Count > 0)
            {
                int[] node = q.Dequeue();
                y = node[0];
                x = node[1];
                for (int i = 0; i < 4; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];
                    if (ny < 0 || nx < 0 || ny >= map.Length || nx >= map[0].Length)
                        continue;
                    if (map[ny][nx] == '#')
                    {
                        q.Enqueue(new int[] { ny, nx }); // 배열 초기화
                        map[ny][nx] = '.'; // 추가된 코드: 방문한 노드를 표시
                    }
                }
            }
        }
    }
}
