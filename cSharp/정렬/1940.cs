using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _1940
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ints);
            int cnt = 0;
            int left = 0;
            int right = n - 1;
            while (left < right)
            {
                int tmp = ints[left] + ints[right];
                if (tmp < m)
                    left++;
                else if (tmp > m)
                    right--;
                else
                {
                    cnt++;
                    left++;
                    right--;
                }
            }
            Console.WriteLine(cnt);
        }

    }
}
