using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 입력 받기
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        // 빙고판 생성 및 입력 처리
        int[,] board = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                board[i, j] = row[j];
            }
        }

        // 전체 '9' 개수와 각 행/열의 '9' 개수를 계산
        int totalNines = 0;
        int[] rowNines = new int[n];
        int[] colNines = new int[m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int nineCount = CountNines(board[i, j]);  // 현재 숫자에서 '9'의 개수
                totalNines += nineCount;  // 전체 '9' 개수 증가
                rowNines[i] += nineCount; // 해당 행의 '9' 개수 증가
                colNines[j] += nineCount; // 해당 열의 '9' 개수 증가
            }
        }

        // 행과 열에서 '9'가 가장 많이 포함된 최대값 찾기
        int maxRowNines = rowNines.Max();
        int maxColNines = colNines.Max();

        // 제거된 행/열의 최대 '9' 개수를 뺀 남은 '9' 개수 계산
        int remainingNines = totalNines - Math.Max(maxRowNines, maxColNines);

        // 결과 출력
        Console.WriteLine(remainingNines);
    }

    // 숫자에서 '9'의 개수를 세는 함수
    static int CountNines(int number)
    {
        return number.ToString().Count(c => c == '9');
    }
}
