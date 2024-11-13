using System;
using System.Globalization;

namespace C_Sharp_Study
{
    internal class YearProgress
    {
        static void Main(string[] args)
        {
            // 입력 파싱
            string input = Console.ReadLine();
            DateTime currentTime = DateTime.ParseExact(input, "MMMM dd, yyyy HH:mm", CultureInfo.InvariantCulture);

            // 현재 연도 시작과 끝 날짜
            DateTime startOfYear = new DateTime(currentTime.Year, 1, 1, 0, 0, 0);
            DateTime endOfYear = new DateTime(currentTime.Year + 1, 1, 1, 0, 0, 0);

            // 경과 시간 비율 계산
            double totalMinutesInYear = (endOfYear - startOfYear).TotalMinutes;
            double minutesElapsed = (currentTime - startOfYear).TotalMinutes;
            double percentage = (minutesElapsed / totalMinutesInYear) * 100;

            // 결과 출력
            Console.WriteLine(percentage);
        }
    }
}
