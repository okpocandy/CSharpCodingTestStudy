using System;

namespace C_Sharp_Study.cSharp.구현
{
    internal class 임시반장정하기
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] classes = new int[n, 5]; // 학생 수 x 학년 데이터 저장

            // 학생들의 반 정보 입력
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < 5; j++)
                {
                    classes[i, j] = int.Parse(input[j]);
                }
            }

            int maxCount = 0; // 가장 많은 같은 반이었던 학생 수
            int leader = 0;   // 임시 반장 번호

            // 각 학생에 대해 같은 반이었던 사람 수 계산
            for (int i = 0; i < n; i++)
            {
                int count = 0; // 현재 학생의 같은 반이었던 사람 수

                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue; // 자기 자신 제외

                    // 학년별로 같은 반이었던 적이 있는지 체크
                    for (int k = 0; k < 5; k++)
                    {
                        if (classes[i, k] == classes[j, k])
                        {
                            count++;
                            break; // 한 학년에서 같은 반이면 추가 비교 생략
                        }
                    }
                }

                // 최대값 및 반장 후보 업데이트
                if (count > maxCount || (count == maxCount && i < leader))
                {
                    maxCount = count;
                    leader = i;
                }
            }

            Console.WriteLine(leader + 1); // 학생 번호는 1부터 시작
        }
    }
}
