using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.탐색
{
    internal class _2805
    {
        static long ans = 0;
        static void Main(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = NM[0];
            int M = NM[1];

            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(array);

            BS(array, M, 0, array[N - 1]);
            Console.WriteLine(ans);
        }
        static void BS(int[] array, int target, int start, int end)
        {
            if (start > end)
            {
                return;
            }
            int mid = (start + end) / 2;
            int[] ints = Array.FindAll(array, x => x > mid);
            long result = 0;
            foreach (int height in array)
            {
                if (height > mid)
                {
                    result += (height - mid);
                }
            }
            if (result < target)
            {
                BS(array, target, start, mid - 1);
            }
            else
            {
                ans = mid;
                BS(array, target, mid + 1, end);
            }
        }
    }
}


