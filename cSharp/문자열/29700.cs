using System;

class Program
{
    static void Main()
    {
        // 입력 받기
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]); // 세로줄 수
        int M = int.Parse(input[1]); // 가로줄 수
        int K = int.Parse(input[2]); // 동아리원 수

        // 좌석 예매 현황을 저장할 배열
        char[,] seats = new char[N, M];

        for (int i = 0; i < N; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < M; j++)
            {
                seats[i, j] = row[j];
            }
        }

        int count = 0;

        // 각 줄을 확인하여 연속된 K개의 빈 좌석을 찾기
        for (int i = 0; i < N; i++)
        {
            int consecutive = 0; // 연속된 빈 좌석 수

            for (int j = 0; j < M; j++)
            {
                if (seats[i, j] == '0') // 빈 좌석일 경우
                {
                    consecutive++;
                }
                else // 예약된 좌석일 경우
                {
                    consecutive = 0; // 연속 카운트 리셋
                }

                // 연속된 빈 좌석이 K개 이상일 경우
                if (consecutive >= K)
                {
                    count++; // 경우의 수 증가
                }
            }
        }

        // 결과 출력
        Console.WriteLine(count);
    }
}
