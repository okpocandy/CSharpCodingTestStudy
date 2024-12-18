using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _18310
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] houses = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(houses);

            // 중앙값을 찾는 방식으로 최적화
            int median = houses[(n - 1) / 2];
            Console.WriteLine(median);
        }
    }
}
