using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] room = new char[n, n];

        // 방 구조 입력
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                room[i, j] = line[j];
            }
        }

        int horizontal = 0; // 가로로 누울 수 있는 자리
        int vertical = 0;   // 세로로 누울 수 있는 자리

        // 가로 방향 자리 계산
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (room[i, j] == '.') count++;
                else count = 0;

                if (count == 2) horizontal++; // 2칸 이상 연속되면 자리 추가
            }
        }

        // 세로 방향 자리 계산
        for (int j = 0; j < n; j++)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (room[i, j] == '.') count++;
                else count = 0;

                if (count == 2) vertical++; // 2칸 이상 연속되면 자리 추가
            }
        }

        // 결과 출력
        Console.WriteLine($"{horizontal} {vertical}");
    }
}
