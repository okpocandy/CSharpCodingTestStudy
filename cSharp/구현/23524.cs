using System;
using System.Linq;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _23524
    {
        static void Main(string[] args)
        {
            // 입력 받기
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = nm[0];
            int M = nm[1];
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // 총 공부할 수 있는 시간
            int totalTime = 24 * N;

            // 각 과목에 대해 필요한 공부 시간을 계산하고, 
            // 그 공부 시간만큼 점수를 더한 후, 남은 시간을 계산한다.
            int totalScore = 0;

            for (int i = 0; i < M; i++)
            {
                // 현재 과목의 시작 점수
                int currentScore = a[i];
                // 현재 과목의 시간당 점수 상승량
                int increasePerHour = b[i];

                // 현재 과목에서 목표 점수(100점)까지 가려면 몇 시간이 필요한지 계산
                if (currentScore < 100)
                {
                    int maxPossibleTime = (100 - currentScore) / increasePerHour;
                    if ((100 - currentScore) % increasePerHour != 0)
                    {
                        maxPossibleTime++;
                    }

                    // 과목에 공부할 수 있는 시간을 배정
                    int studyTime = Math.Min(maxPossibleTime, totalTime);

                    // 공부 시간만큼 점수 상승
                    currentScore += studyTime * increasePerHour;
                    totalTime -= studyTime;
                }

                // 최종 성적에 추가
                totalScore += Math.Min(currentScore, 100);
            }

            // 최종 성적 출력
            Console.WriteLine(totalScore);
        }
    }
}
