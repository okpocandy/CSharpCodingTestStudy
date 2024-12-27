using System;
using System.Collections.Generic;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _26215
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] snow = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // 최대 힙을 구현하기 위해 우선순위 큐 사용
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            foreach (var s in snow)
            {
                if (s > 0)
                    pq.Enqueue(s, -s); // 우선순위를 음수로 설정하여 최대 힙 구현
            }

            int cnt = 0;

            while (pq.Count > 0)
            {
                if (cnt > 1440) // 24시간 초과 시 -1 출력
                {
                    Console.WriteLine(-1);
                    return;
                }

                int first = pq.Dequeue(); // 가장 눈이 많은 집
                int second = 0;

                if (pq.Count > 0)
                    second = pq.Dequeue(); // 두 번째로 눈이 많은 집

                // 두 집의 눈을 1씩 제거
                first--;
                second--;

                // 제거 후 다시 큐에 삽입
                if (first > 0) pq.Enqueue(first, -first);
                if (second > 0) pq.Enqueue(second, -second);

                cnt++;
            }

            Console.WriteLine(cnt <= 1440 ? cnt : -1);
        }
    }
}
