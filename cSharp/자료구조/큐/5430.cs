using System;
using System.Collections.Generic;

class AC
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string commands = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string arrayInput = Console.ReadLine();

            // 배열에서 숫자만 파싱하여 Deque 초기화
            var deque = new LinkedList<int>();
            if (n > 0)
            {
                string[] elements = arrayInput.Substring(1, arrayInput.Length - 2).Split(',');
                foreach (var element in elements)
                    deque.AddLast(int.Parse(element));
            }

            bool isReversed = false;
            bool isError = false;

            foreach (char command in commands)
            {
                if (command == 'R')
                {
                    isReversed = !isReversed;  // 반전 상태 토글
                }
                else if (command == 'D')
                {
                    if (deque.Count == 0)
                    {
                        isError = true;
                        break;
                    }

                    // 반전 상태에 따라 앞 또는 뒤에서 제거
                    if (isReversed)
                        deque.RemoveLast();
                    else
                        deque.RemoveFirst();
                }
            }

            if (isError)
            {
                Console.WriteLine("error");
            }
            else
            {
                // 반전 상태에 따라 정방향 또는 역방향으로 출력
                var result = new List<int>(deque);
                if (isReversed)
                    result.Reverse();

                Console.WriteLine("[" + string.Join(",", result) + "]");
            }
        }
    }
}
