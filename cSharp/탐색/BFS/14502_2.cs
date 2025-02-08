using System;
using System.Collections.Generic;

class 연구소
{
    static int n, m;
    static int[,] map;
    static int maxSafeArea = 0;
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };

    static void Main()
    {
        string inputLine = Console.ReadLine();
        if (string.IsNullOrEmpty(inputLine))
        {
            return;
        }

        string[] input = inputLine.Split();
        n = int.Parse(input[0]);
        m = int.Parse(input[1]);

        map = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
            {
                return;
            }

            string[] row = line.Split();
            for (int j = 0; j < m; j++)
            {
                map[i, j] = int.Parse(row[j]);
            }
        }

        BuildWall(0);
        Console.WriteLine(maxSafeArea);
    }

    static void BuildWall(int count)
    {
        if (count == 3)
        {
            maxSafeArea = Math.Max(maxSafeArea, GetSafeArea());
            return;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (map[i, j] == 0)
                {
                    map[i, j] = 1;
                    BuildWall(count + 1);
                    map[i, j] = 0;
                }
            }
        }
    }

    static int GetSafeArea()
    {
        int[,] tempMap = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                tempMap[i, j] = map[i, j];
            }
        }

        Queue<(int, int)> queue = new Queue<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (tempMap[i, j] == 2)
                {
                    queue.Enqueue((i, j));
                }
            }
        }

        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();

            for (int d = 0; d < 4; d++)
            {
                int nx = x + dx[d];
                int ny = y + dy[d];

                if (nx >= 0 && nx < n && ny >= 0 && ny < m && tempMap[nx, ny] == 0)
                {
                    tempMap[nx, ny] = 2;
                    queue.Enqueue((nx, ny));
                }
            }
        }

        int safeArea = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (tempMap[i, j] == 0)
                {
                    safeArea++;
                }
            }
        }

        return safeArea;
    }
}
