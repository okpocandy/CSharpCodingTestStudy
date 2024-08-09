using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.정렬
{
    internal class _3273
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int x = int.Parse(Console.ReadLine());
            Array.Sort(ints);
            int l = 0;
            int r = ints.Length - 1;
            int cnt = 0;
            while (l < r)
            {
                if (ints[l] + ints[r] < x)
                {
                    l++;
                }
                else if (ints[l] + ints[r] > x)
                {
                    r--;
                }
                else
                {
                    cnt++;
                    l++;
                    r--;
                }
            }
            Console.WriteLine(string.Join(", ", ints));
            Console.WriteLine(cnt);
        }
    }
}
