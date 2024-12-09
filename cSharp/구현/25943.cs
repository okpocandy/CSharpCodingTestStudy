using System;

namespace C_Sharp_Study.cSharp.구현
{
    class _25943
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] stones = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int left = 0, right = 0;
            int[] gs = new int[] { 1, 2, 5, 10, 20, 50, 100 };

            // 자갈 분배
            foreach (int stone in stones)
            {
                if (left <= right)
                    left += stone;
                else
                    right += stone;
            }

            // 무게 차이 계산
            int dif = Math.Abs(left - right);
            int cnt = 0;

            // 최소 무게추 계산
            foreach (int weight in gs.Reverse())
            {
                while (dif >= weight)
                {
                    dif -= weight;
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
