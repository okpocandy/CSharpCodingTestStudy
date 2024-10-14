using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _2002
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // 차량 입구 순서 저장
            Dictionary<string, int> entranceOrder = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string car = Console.ReadLine();
                entranceOrder[car] = i;  // 차량 번호와 입구 순서 저장
            }

            // 차량 출구 순서 저장
            List<int> exitOrder = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string car = Console.ReadLine();
                exitOrder.Add(entranceOrder[car]);  // 출구 순서에 해당하는 입구 인덱스 추가
            }

            // 추월한 차량 수 계산 (좌측의 작은 수가 뒤쪽에 나오면 추월)
            int overtakeCount = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (exitOrder[i] > exitOrder[j])  // 추월 발생
                    {
                        overtakeCount++;
                        break;  // 해당 차량에서 추월이 확인되면 다음으로 이동
                    }
                }
            }

            Console.WriteLine(overtakeCount);
        }
    }
}
