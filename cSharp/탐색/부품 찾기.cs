using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class 부품_찾기
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] have = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int M = int.Parse(Console.ReadLine());
            int[] req = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(have);   // 이진 탐색을 수행하기 위해 사전에 정렬 수행
            for(int j=0; j<M; j++)
            {
                if (BS(have, req[j], 0, have.Length - 1) == -1)
                    Console.WriteLine("no");
                else
                    Console.WriteLine("yes");
            }

        }
        static int BS(int[] array, int target, int start, int end)
        {
            if (start > end) { return -1; }
            int mid = (start + end) / 2;

            if (array[mid] == target) { return mid; }
            else if (array[mid] > target) { return BS(array, target, start, end - 1); }
            else { return BS(array, target, mid + 1, end); }

        }

    }
}

/*

5
8 3 7 9 2
3
5 7 9

*/